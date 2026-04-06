using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp8_3
{
    internal class Note
    {
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Amount} грн - {Description}";
        }
    }
}
