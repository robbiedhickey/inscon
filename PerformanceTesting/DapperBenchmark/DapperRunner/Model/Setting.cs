using System;

namespace DapperRunner.Model
{
    public class Setting
    {
        public int SettingId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public int EditLevel { get; set; }

        //properties not in table will not be bound to
        public string PropertyNotInDB { get; set; }

        public override string ToString()
        {
            return String.Format("SettingId {0} with value {1}", SettingId, Value);
        }
    }
}