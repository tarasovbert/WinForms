using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    [Serializable]
    public static class Repository
    {
        [Serializable]
        internal class Data
        {        
            private string login;
            private string password;
            private string eMail;
            private string name;
            private string surname;

            #region PROPERTIES
            public string Login
            {
                get { return login; }
                set { login = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public string EMail
            {
                get { return eMail; }
                set { eMail = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }
            #endregion
            public Data(string login, string password,
              string eMail, string name, string surname)
            {
                this.login = login;
                this.password = password;
                this.eMail = eMail;
                this.name = name;
                this.surname = surname;
            }
        }

        internal static List<Data> Users = new List<Data>();

        public static void AddUser(string login, string password,
            string eMail, string name = "Some_name", string surname = "Some_surname")
        {
            Users.Add(new Data(login, password, eMail, name, surname));
        }

        public static int ContainsEMail(string eMail)
        {
            for (int i = 0; i < Users.Count; i++)           
                if (Users[i].EMail == eMail)
                    return i;
            return -1;            
        }

        public static int ContainsLoginAndPassword(string login, string password)
        {
            for (int i = 0; i < Users.Count; i++)
                if (Users[i].Login == login && Users[i].Password == password)
                    return i;
            return -1;
        }

        public static int ContainsLogin(string login)
        {
            for (int i = 0; i < Users.Count; i++)
                if (Users[i].Login == login)
                    return i;
            return -1;
        }
        
        public static int ContainsPassword(string password)
        {
            for (int i = 0; i < Users.Count; i++)
                if (Users[i].Password == password)
                    return i;
            return -1;
        }

    }
}
