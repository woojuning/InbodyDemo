using Inbody.Models;
using Inbody.Repository;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.Controller
{
    public class AnalysisUseCase
    {
        private UserInfoRepo _userRepo;
        private UserAnalysisRepo _userAnalysisRepo;

        public AnalysisUseCase()
        {
            _userRepo = new UserInfoRepo();
            _userAnalysisRepo = new UserAnalysisRepo();
        }

        public string GetWeight(string msg)
        {
            string message = "";
            try
            {
                message = TCPIP_Client.GetDataFromServer(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            return message;
        }

        public UserAnalysisModel GetAnalysisInfo(UserAnalysisModel userAnalysis)
        {
            var res = TCPIP_Client.GetDataFromServer("Analysis").Split(',').ToList();

            userAnalysis.SkeletalMuscleMass = double.Parse(res[0]);
            userAnalysis.BodyFatMass = double.Parse(res[1]);

            return userAnalysis;
        }

        #region Inbody Test
        // 체중
        public double GetWeightPerWidth(UserInfoModel userInfo, int width)
        {
            // 한칸에 20이므로 표준에 해당하는 몸무게까지 4칸 즉 width = 80
            // 표준 몸무게 / 80 => 1kg당 기준 width
            // 현재 체중 * x = width 
            // width까지 증가하도록 timer를 돌리면 된다. 
            // 표준 몸무게 
            // > 남자 : (키 - 100) * 0.9
            // > 여자 : (키 - 95) * 0.85
            var standardWeight = userInfo.Gender ?
                (userInfo.Height - 95) * 0.85 :
                (userInfo.Height - 100) * 0.9;
            var weightPerWidth = width / standardWeight;

            return weightPerWidth;
        }
        // 골격근량 (kg)
        public double GetMuscleMasstPerWidth(UserInfoModel userInfo, int width)
        {
            // 표준 몸무게 
            // > 남자 : (키 - 100) * 0.9 * 0.45
            // > 여자 : (키 - 95) * 0.85 * 0.38
            var standardMuscleMass = userInfo.Gender ?
                (userInfo.Height - 95) * 0.85 * 0.38:
                (userInfo.Height - 100) * 0.9 * 0.45;
            var weightPerMuscleMass = width / standardMuscleMass;

            return weightPerMuscleMass;
        }

        // 체지방률 (%)
        public double GetBodyFatPercentPerWidth(UserInfoModel userInfo, int width)
        {
            // 몸무게 / (키 * 키 ) = 체지방률
            var standardMuscleMass = userInfo.Gender ?
                ((userInfo.Height - 95) * 0.85) / (userInfo.Height * userInfo.Height) * 10000:
                ((userInfo.Height - 100) * 0.9) / (userInfo.Height * userInfo.Height) * 10000;
            var weightPerMuscleMass = width / standardMuscleMass;

            return weightPerMuscleMass;
        }

        #endregion

        #region DataBase
        public void SaveUserAnalysis(UserInfoModel user, UserAnalysisModel userAnalysis)
        {
            // 1) user가 db에 존재하는지 확인 
            // 2) 존재하면 Update, 없으면 Insert
            // 3) UserAnalysis를 저장한다. 
            try
            {
                var isExist = _userRepo.IsExistUser(user.MemberNum);
                if (isExist)
                {
                    _userRepo.Update(user);
                }
                else
                {
                    _userRepo.Insert(user);
                }

                userAnalysis.MemberNum = user.MemberNum;

                // 2024-02-18 DateTime으로 저장함.
                userAnalysis.MeasureTime = DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
                //var now = DateTime.Now;
                //userAnalysis.MeasureTime = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);

                _userAnalysisRepo.Insert(userAnalysis);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion


    }
}
