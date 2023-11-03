using APIDotNetCoreJWTMysql.Model;
using System;
using System.Collections.Generic;

namespace APIDotNetCoreJWTMysql.Data.DapperORM.Interface
{
    public interface IAccountRepository
    {
        public void InsertAccount(string userLogin, DateTime dateRegister, string inputType, decimal inputValue);

        public void deleteAccount(int id);

        public Account GetAccount(int id);

        public void UpdateAccount(int id, string userLogin, DateTime dateRegister, string inputType, decimal inputValue);

        public IEnumerable<Account> listAccount();

    }
}
