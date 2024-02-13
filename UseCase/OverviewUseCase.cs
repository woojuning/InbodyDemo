using Inbody.Models;
using Inbody.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.Controller
{
    public class OverviewUseCase
    {
        private UserInfoRepo _userInfoRepo;
        private UserAnalysisRepo _userAnalysisRepo;
        

        public OverviewUseCase()
        {
            _userInfoRepo = new UserInfoRepo();
            _userAnalysisRepo = new UserAnalysisRepo();
        }

        #region DB
        public bool IsExistUser(string memberNum)
        {
            bool isExist = false;

            try
            {
                isExist =  _userInfoRepo.IsExistUser(memberNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isExist;
        }

        // MemberNum인 User의 모든 측정 기록을 가져온다.
        public List<UserAnalysisModel> GetAnalysisById(string memberNum)
        {
            var list = new List<UserAnalysisModel>();

            try
            {
                list = _userAnalysisRepo.GetById(memberNum);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

        public UserInfoModel GetUserInfoById(string memberNum)
        {
            var user = new UserInfoModel();

            try
            {
                user = _userInfoRepo.GetById(memberNum).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }
        #endregion

    }
}
