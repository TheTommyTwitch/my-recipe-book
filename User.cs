using System;
namespace myrecipebook
{
    public class User
    {
        private int _id;
        private string _email;
        private string _password;
        private string _first_name;
        private string _last_name;

        public User(int id, string email, string password, string first_name, string last_name)
        {
            this._id = id;
            this._email = email;
            this._password = password;
            this._first_name = first_name;
            this._last_name = last_name;
        }

        public int GetID()
        {
            return this._id;
        }

        public void SetID(int id)
        {
            this._id = id;
        }

        public string GetEmail()
        {
            return this._email;
        }

        public void SetEmail(string email)
        {
            this._email = email;
        }

        public string GetPassword()
        {
            return this._password;
        }

        public void SetPassword(string password)
        {
            this._password = password;
        }

        public string GetFirstName()
        {
            return this._first_name;
        }

        public void SetFirstName(string name)
        {
            this._first_name = name;
        }

        public string GetLastName()
        {
            return this._last_name;
        }

        public void SetLastName(string name)
        {
            this._last_name = name;
        }
    }
}
