using System;

namespace APIDotNetCoreJWTMysql.Model
{
    public class Account
    {
        public Account(int id, string userLogin, DateTime dateRegister, string inputType, decimal inputValue)
        {
            this.id = id;
            UserLogin = userLogin;
            this.dateRegister = dateRegister;
            this.inputType = inputType;
            this.inputValue = inputValue;
        }

        public int id { get; set; }
        public string UserLogin { get; set; }
        public DateTime dateRegister { get; set; }
        public string inputType { get; set; }
        public decimal inputValue { get; set; }
    }
}
