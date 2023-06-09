using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sea : Vehicle
    {
        string _type;

        public Sea(string color, string type) : base(color)
        {
            _type = type;
        }

        public string Type { get => _type; set => _type = value; }

        public override string ToString()
        {
            return base.ToString() + $"- It is a {_type}";
        }
    }
}
