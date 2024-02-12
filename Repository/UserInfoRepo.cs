using Connect;
using Inbody.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbody.Repository
{
    public class UserInfoRepo
    {
        public void Insert(UserInfoModel user, IDbTransaction transaction = null)
        {
            var query = $@"INSERT INTO TB_UserInfo
                               VALUES (
                                          '{user.MemberNum}',
                                          '{user.PhoneNum}',
                                           {user.Height},
                                           {user.Age},
                                           {(user.Gender ? 1 : 0)}
                                         )";
            try
            {
                Connection.Execute(query, parameters : null, transaction : transaction, commandType : CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(UserInfoModel user, IDbTransaction transaction = null)
        {
            var query = $@"UPDATE TB_UserInfo
                               SET 
                                    PhoneNum = '{user.PhoneNum}',
                                    Height = {user.Height},
                                    Age = {user.Age},
                                    Gender = {(user.Gender ? 1 : 0)}
                               WHERE MemberNum = '{user.MemberNum}'";

            try
            {
                Connection.Execute(query, parameters: null, transaction: transaction, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsExistUser(string memberNum, IDbTransaction transaction = null)
        {
            var query = $@"SELECT COUNT(*) FROM TB_UserInfo
                               WHERE MemberNum = '{memberNum}'";

            try
            {
                var res = Connection.QueryFirstOrDefault<int>(query, parameters: null, transaction: transaction, commandType: CommandType.Text);

                return res == 1 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
