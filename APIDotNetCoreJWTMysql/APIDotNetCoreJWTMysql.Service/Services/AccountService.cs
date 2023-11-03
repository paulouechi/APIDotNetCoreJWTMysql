using System;
using System.Collections.Generic;
using System.Linq;
using APIDotNetCoreJWTMysql.Data.DapperORM.Interface;
using APIDotNetCoreJWTMysql.Data.DapperORM.Repositories;
using APIDotNetCoreJWTMysql.Model;
using APIDotNetCoreJWTMysql.Service.Interface;

namespace APIDotNetCoreJWTMysql.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void deleteAccount(int id)
        {
            _accountRepository.deleteAccount(id);
        }

        public Account GetAccount(int id)
        {
            return _accountRepository.GetAccount(id);
        }

        public List<Account> GetAccountList()
        {
            var listAccount = _accountRepository.listAccount().ToList();
            return listAccount;
        }

        public void InsertAccount(string userLogin, DateTime dateRegister, string inputType, decimal inputValue)
        {
            _accountRepository.InsertAccount(userLogin, dateRegister, inputType, inputValue);
        }

        public void UpdateAccount(int id, string userLogin, DateTime dateRegister, string inputType, decimal inputValue)
        {
            _accountRepository.UpdateAccount(id, userLogin, dateRegister, inputType, inputValue);
        }
    }
}
