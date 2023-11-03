using Dapper;
using System;
using System.Data;
using System.Linq;
using APIDotNetCoreJWTMysql.Data.DapperORM.Interface;
using System.Collections.Generic;
using APIDotNetCoreJWTMysql.Model;

namespace APIDotNetCoreJWTMysql.Data.DapperORM.Repositories
{
    public class AccountRepository: BaseRepository, IAccountRepository
    {
        public void deleteAccount(int id)
        {
            using var db = GetMySqlConnection();
            string sql = "delete from Account where id = " + id.ToString(); ;
            db.Execute(sql);
        }

        public Account GetAccount(int id)
        {
            using var db = GetMySqlConnection();
            string sql = "select id, UserLogin, DateRegister, InputType, InputValue from Account where id = " + id.ToString();

            return db.Query<Account>(sql).FirstOrDefault();
        }

        public void InsertAccount(string userLogin, DateTime dateRegister, string inputType, decimal inputValue)
        {
            using var db = GetMySqlConnection();
            const string sql = @"insert into Account (UserLogin, DateRegister, InputType, InputValue) values (@UserLogin, @DateRegister, @InputType, @InputValue)";

            db.Execute(sql, new { UserLogin = userLogin, DateRegister = dateRegister, InputType = inputType, InputValue = inputValue }, commandType: CommandType.Text);
        }

        public void UpdateAccount(int id, string userLogin, DateTime dateRegister, string inputType, decimal inputValue)
        {
            using var db = GetMySqlConnection();
            string sql = "update Account set UserLogin = '" + userLogin  + "', DateRegister = '" + dateRegister.ToString("yyyy/MM/dd HH:mm:ss") + "' , InputType = '" + inputType +  "', InputValue = " + inputValue.ToString().Replace(",",".") + " where id =  " + id.ToString(); ;
            db.Execute(sql);

        }

        public IEnumerable<Account> listAccount()
        {
            using var db = GetMySqlConnection();
            const string sql = "select Id, UserLogin, DateRegister, InputType, InputValue from Account";

            return db.Query<Account>(sql);
        }
    }
}
