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

        public OverviewUseCase()
        {
            _userInfoRepo = new UserInfoRepo();
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
        #endregion

    }
}
