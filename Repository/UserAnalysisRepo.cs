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
    public class UserAnalysisRepo
    {
        public void Insert(UserAnalysisModel analysisInfo, IDbTransaction transaction = null)
        {
            var query = $@"INSERT INTO TB_UserAnalysis
                               VALUES (
                                          '{analysisInfo.MemberNum}',
                                           {analysisInfo.Weight},
                                           {analysisInfo.SkeletalMuscleMass},
                                           {analysisInfo.BodyFatMass},
                                           '{analysisInfo.MeasureTime}'
                                         )";
            try
            {
                Connection.Execute(query, parameters: null, transaction: transaction, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
