using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListBoxDataSource
{
   public class Car
    {
      //  public string Name { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Name is NullOrEmpty");
                name = value;
            }
        }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format($"{Name}: {Price}");
        }
    }
}
