using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace RawEnterpriseClass
{
    /// <summary>
    /// 
    /// </summary>
    [HasSelfValidation]
    public class EnterpriseClass : INotifyPropertyChanged, 
                                   IComparable<EnterpriseClass>, 
                                   IEditableObject
    {
        #region Variables

        /// <summary>
        /// Contains all of the variables and objects that can be edited and 
        /// rolled back.
        /// </summary>
        private struct ClassData
        {
            internal int _id;
        }

        private ClassData _liveData;
        private ClassData _backData;
        private bool _inTxn = false;

        public event PropertyChangedEventHandler PropertyChanged;
        private ValidatorFactory _valFactory;
        private Validator<EnterpriseClass> _validator;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseClass" /> class.
        /// </summary>
        public EnterpriseClass()
        {
            // Initialize the variables
            _liveData = new ClassData();
            _liveData._id = -1;

            // Setup the validators
            _valFactory = EnterpriseLibraryContainer.Current.GetInstance<ValidatorFactory>();
            _validator = _valFactory.CreateValidator<EnterpriseClass>();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return ID.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms 
        /// and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is 
        /// equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with 
        /// this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal 
        /// to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <example>
        /// 
        ///    // If we are comparing to null or a different type then return false.
        ///    if (obj == null || GetType() != obj.GetType())
        ///        return false;
        ///
        ///    // Cast the passed in object to one of this type
        ///    EnterpriseClass thisObj = (EnterpriseClass) obj;
        ///
        ///    // Return a boolean construct.  In this case I have used the ID 
        ///    // property to do the compare.  For a real class you would 
        ///     return something like: 
        ///     return( _intVar.Equals(thisObj.IntVar) && 
        ///             _stringVar.Equals(thisObj.StringVar, StringComparison.CurrentCultureIgnoreCase);
        ///
        /// </example>
        public override bool Equals(object obj)
        {
            // If we are comparing to null or a different type then return false.
            if (obj == null || GetType() != obj.GetType())
                return false;

            // Cast the passed in object to one of this type
            EnterpriseClass thisObj = (EnterpriseClass) obj;

            return (_liveData._id.Equals(thisObj.ID));
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates the specified validation results.
        /// </summary>
        /// <param name="validationResults">The validation results.</param>
        [SelfValidation]
        private void ValidateThis(ValidationResults validationResults)
        {
            if (_liveData._id < 1)
            {
                validationResults.AddResult(
                    new ValidationResult("ID may not be zero or have a negative value.", 
                                         this, "ID", null, null));
            }

            if (_inTxn)
            {
                validationResults.AddResult(
                    new ValidationResult("Edits must be committed or rolled back for the object to be valid",
                                         this, "inTxn", null, null));
            }
        }

        /// <summary>
        /// Notifies the property changed.
        /// </summary>
        private void NotifyPropertyChanged([CallerMemberName] String caller = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }

        /// <summary>
        /// Sends the NotifyPropertyChanged event for each property.  This 
        /// should only be called when you are doing a CancelEdit() so that 
        /// the UI can update itself when the internal ClassData struct is 
        /// filled with the backup data.
        /// </summary>
        private void ExplicitNotifyPropertyChanged()
        {
            var handler = PropertyChanged;

            foreach (var prop in this.GetType().GetProperties())
            {
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(prop.Name));
                }
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Compares the current object to another object of the same type
        /// </summary>
        /// <param name="other">The object to compare to.</param>
        /// <returns>
        /// Less than zero - This object is less than the other parameter.
        /// Zero = This object is equal to other.
        /// Greater than zero - This object is greater than the other
        /// </returns>
        /// <example>
        /// 
        /// int retValue = 0;
        ///
        /// if (other == null)
        ///        retValue = 1;
        ///    else
        ///    {
        ///        retValue = this.ID.CompareTo(other.ID);
        ///
        ///        if (retValue.Equals(0))
        ///        {
        ///            retValue = this.anotherProperty.CompareTo(other.anotherProperty);
        ///
        ///            if (retValue.Equals(0))
        ///            {
        ///                retValue = this.yetAnotherProperty.CompareTo(other.yetAnotherProperty);
        ///            }
        ///        }
        ///    }
        ///
        ///    return retValue;
        ///
        /// </example>
        public int CompareTo(EnterpriseClass other)
        {
            int retValue = 0;

            if (other == null)
                retValue = 1;
            else
            {
                retValue = ID.CompareTo(other.ID);
            }

            return retValue;
        }

        /// <summary>
        /// Begins an edit on an object.
        /// </summary>
        public void BeginEdit()
        {
            if (!_inTxn)
            {
                _backData = _liveData;
                _inTxn = true;
            }
        }

        /// <summary>
        /// Discards changes since the last 
        /// <see cref="M:System.ComponentModel.IEditableObject.BeginEdit" /> call.
        /// </summary>
        public void CancelEdit()
        {
            if (_inTxn)
            {
                _liveData = _backData;
                _backData = new ClassData();
                ExplicitNotifyPropertyChanged();
                _inTxn = false;
            }
        }

        /// <summary>
        /// Pushes changes since the last 
        /// <see cref="M:System.ComponentModel.IEditableObject.BeginEdit" /> or 
        /// <see cref="M:System.ComponentModel.IBindingList.AddNew" /> call 
        /// into the underlying object.
        /// </summary>
        public void EndEdit()
        {
            _backData = new ClassData();
            _inTxn = false;
        }

        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            return Validate().IsValid;
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <returns></returns>
        public ValidationResults Validate()
        {
            return _validator.Validate(this);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        public int ID
        {
            get { return _liveData._id; }
            set
            {
                if (_liveData._id != value)
                {
                    _liveData._id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion
    }
}
