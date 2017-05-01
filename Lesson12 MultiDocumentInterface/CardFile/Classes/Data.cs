using System.ComponentModel;

namespace CarFile.Classes
{
    public static class Data
    {
        public static BindingList<Car> Cars = new BindingList<Car>();
        public static BindingList<string> Importers = new BindingList<string>();
        public static BindingList<string> CountriesOfOrigin = new BindingList<string>();
    }
}
