using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class EnumerationModel
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }

    public class BirthdayContent
    {
        public Guid Guid { get; set; }
        public string Birthday { get; set; }
        public string Content { get; set; }
    }

    public class FileInformation
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }

    [Serializable]
    public class UserConfig
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsSaveName { get; set; }
        public bool IsSavePassword { get; set; }
        public bool IsNotRemind { get; set; }
        public DateTime RemindDate { get; set; }
        public string SkinName { get; set; }
    }
}
