using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneShop
{
    [Serializable]
    public class CellPhone
    {
        #region FIELDS
        string model;
        string oS;        
        double cPU;
        decimal price;
        string picture;
        List<string> options;
        #endregion

        #region PROPERTIES
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string OS
        {
            get { return oS; }
            set { oS = value; }
        }
        public double CPU
        {
            get { return cPU; }
            set { cPU = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public List<string> Options
        {
            get { return options; }
            set { options = value; }
        }
        #endregion

        #region CTORS
        public CellPhone() { }

        public CellPhone(string model, string oS, double cPU, decimal price)
        {
            Model = model;
            OS = oS;
            CPU = cPU;
            Price = price;
            Picture = @"PhonesPictures\defaultPhone.jpg";
        }

        public CellPhone(string model, string oS, double cPU, decimal price, string picture)
        {
            Model = model;
            OS = oS;
            CPU = cPU;
            Price = price;
            Picture = picture;
        }

        public CellPhone(string model, string oS, double cPU, decimal price, string picture, List<string> options)
        {
            Model = model;
            OS = oS;
            CPU = cPU;
            Price = price;
            Picture = picture;
            Options = options;
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0} - {1}. Price {2}", Model, CPU, Price);
        }
    }
}
