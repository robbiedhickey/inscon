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
        private bool _isDirty;

        public abstract List<IDbCommand> SaveCommands { get; }
        public abstract List<IDbCommand> RemoveCommands { get; }

        protected bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        public void Set( ref object target, object value )
        {
            if( target != value )
            {
                _isDirty = true;
                target = value;
            }
        }

        public void Set( ref string target, string value)
        {
            if( target != value )
            {
                _isDirty = true;
                target = value;
            }
        }

		public void Set( ref int target, int value )
		{
			if( target != value )
			{
				_isDirty = true;
				target = value;
			}
		}

        public void Save()
        {
            Execute(SaveCommands);
        }

        public void Remove()
        {
            Execute(RemoveCommands);
        }

        private void Execute(List<IDbCommand> commands)
        {
            if (commands != null && commands.Count > 0)
            {
                Context.ExecuteNonQuery(commands);
            }            
        }

        protected static List<IDbCommand> CommandList(IDbCommand command)
        {
            var commandList = new List<IDbCommand> {command};

            return commandList;
        }
    }
}
