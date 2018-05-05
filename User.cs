using System;
namespace myrecipebook
{
    public class User
    {
        protected int _id;
        protected string _email;
        protected string _password;
        protected string _first_name;
        protected string _last_name;

        public User(int id, string email, string password, string first_name, string last_name)
        {
            this._id = id;
            this._email = email;
            this._password = password;
            this._first_name = first_name;
            this._last_name = last_name;
        }

        public virtual int GetID()
        {
            return this._id;
        }

        public virtual void SetID(int id)
        {
            this._id = id;
        }

        public virtual string GetEmail()
        {
            return this._email;
        }

        public virtual void SetEmail(string email)
        {
            this._email = email;
        }

        public virtual string GetPassword()
        {
            return this._password;
        }

        public virtual void SetPassword(string password)
        {
            this._password = password;
        }

        public virtual string GetFirstName()
        {
            return this._first_name;
        }

        public virtual void SetFirstName(string name)
        {
            this._first_name = name;
        }

        public virtual string GetLastName()
        {
            return this._last_name;
        }

        public virtual void SetLastName(string name)
        {
            this._last_name = name;
        }
    }
}
