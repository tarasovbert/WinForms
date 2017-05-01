using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class User
    {
        private string name;
        private string surname;
        private string login;
        private string eMail;
        private string password;

        #region PROPERTIES
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

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion


    }
}
