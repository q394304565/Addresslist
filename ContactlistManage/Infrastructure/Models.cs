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
}
