using System;
using System.Collections.Generic;
using APIDotNetCoreJWTMysql.Model;

namespace APIDotNetCoreJWTMysql.Service.Interface
{
    public interface IAccountService
    {
        List<Account> GetAccountList();

        public void InsertAccount(string userLogin, DateTime dateRegister, string inputType, decimal inputValue);

        public void deleteAccount(int id);

        public Account GetAccount(int id);

        public void UpdateAccount(int id, string userLogin, DateTime dateRegister, string inputType, decimal inputValue);

    }
}
