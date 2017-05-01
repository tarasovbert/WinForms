using System;

namespace CarFile.Classes
{
    [Serializable]
    public class Car
    {
        private int number;
        private string mark;
        private string countryOfOrigin;
        private int mass;
        private string importer;

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }

        public string Mark
        {
            get { return mark; }
            private set { mark = value; }
        }

        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            private set { countryOfOrigin = value; }
        }

        public int Mass
        {
            get { return mass; }
            private set { mass = value; }
        }

        public string Importer
        {
            get { return importer; }
            private set { importer = value; }
        }

        public Car(int quantity, string mark, string countryOfOrigin, int mass, string importer)
        {
            this.number = quantity;
            this.mark = mark;
            this.countryOfOrigin = countryOfOrigin;
            this.mass = mass;
            this.importer = importer;
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}, from {2}, {3} kg, inmported by {4}",
                number, mark, countryOfOrigin, mass, importer);
        }
    }
}
