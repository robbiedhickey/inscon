using System.Collections.Generic;
using System.Data;

namespace Enterprise.DAL.Framework.Data
{
    /// <summary>
    /// Provides a live representation of a single row of a table
    /// in the database.  It offers a consistent mechanism to persist or delete.
    /// </summary>
    public abstract class DataRecord : DataAccessor, IDataRecord
    {
        /// <summary>
        /// The _is dirty
        /// </summary>
        private bool _isDirty;

        /// <summary>
        /// Gets the save commands.
        /// </summary>
        /// <value>The save commands.</value>
        public abstract List<IDbCommand> SaveCommands { get; }
        /// <summary>
        /// Gets the remove commands.
        /// </summary>
        /// <value>The remove commands.</value>
        public abstract List<IDbCommand> RemoveCommands { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is dirty.
        /// </summary>
        /// <value><c>true</c> if this instance is dirty; otherwise, <c>false</c>.</value>
        protected bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        /// <summary>
        /// Sets the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="value">The value.</param>
        public void Set( ref object target, object value )
        {
            if( target != value )
            {
                _isDirty = true;
                target = value;
            }
        }

        /// <summary>
        /// Sets the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="value">The value.</param>
        public void Set( ref string target, string value)
        {
            if( target != value )
            {
                _isDirty = true;
                target = value;
            }
        }

        /// <summary>
        /// Sets the specified target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="value">The value.</param>
		public void Set( ref int target, int value )
		{
			if( target != value )
			{
				_isDirty = true;
				target = value;
			}
		}

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            Execute(SaveCommands);
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        public void Remove()
        {
            Execute(RemoveCommands);
        }

        /// <summary>
        /// Executes the specified commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
        private void Execute(List<IDbCommand> commands)
        {
            if (commands != null && commands.Count > 0)
            {
                Context.ExecuteNonQuery(commands);
            }            
        }

        /// <summary>
        /// Commands the list.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns>List{IDbCommand}.</returns>
        protected static List<IDbCommand> CommandList(IDbCommand command)
        {
            var commandList = new List<IDbCommand> {command};

            return commandList;
        }
    }
}
