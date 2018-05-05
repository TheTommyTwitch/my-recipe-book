using System;
namespace myrecipebook
{
    public class Admin : User
    {
        public Admin(int id, string email, string password, string first_name, string last_name) : base(id, email, password, first_name, last_name)
        {
        }

        public override int GetID()
        {
            return this._id;
        }

		public override string GetEmail()
		{
            return base.GetEmail();
		}
	}
}
