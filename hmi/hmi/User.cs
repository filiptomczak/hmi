using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmi
{
    class User
    {
        private string login, password, group;
        private string pathName = @"users.txt";
        public User()
        {
            this.login = "user";
            this.password = "password";
            this.group = "user";
        }
        public User(string Login, string Password, string Group)
        {
            this.login = Login;
            this.password = Password;
            this.group = Group;
        }
        public string EncryptDecrypt()
        {
            StringBuilder inputString = new StringBuilder(this.password);
            StringBuilder outputString = new StringBuilder(this.password.Length);
            char c;
            for (int i = 0; i < this.password.Length; i++)
            {
                c = inputString[i];
                c = (char)(c ^ 123);
                outputString.Append(c);
            }
            return outputString.ToString();
        }
        public string Group
        {
            get { return this.group; }
        }
        public string Login
        {
            get { return this.login; }
        }
    }
}
