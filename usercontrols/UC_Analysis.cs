using Inbody.usercontrols.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols
{
    public partial class UC_Analysis : UserControl
    {
        UC_AnalysisWeight _ucAnalysisWeight;
        UC_MemberNumber _ucMemberNumber;
        UC_CheckPersonalInfo _ucCheckPersonInfo;
        UC_PersonalInfoConsent _ucPersonInfoConsent;
        UC_PostureFoot _ucPostureFoot;

        private int _screenIndex;

        public UC_Analysis()
        {
            InitializeComponent();
            _ucAnalysisWeight = new UC_AnalysisWeight();
            _ucMemberNumber = new UC_MemberNumber();
            _ucCheckPersonInfo = new UC_CheckPersonalInfo();
            _ucPersonInfoConsent = new UC_PersonalInfoConsent();
            _ucPostureFoot = new UC_PostureFoot();

            _screenIndex = 0;

            RegisterUserControlEventHandler();
        }

        #region EventHandler

        #region Load
        private void UC_Analysis_Load(object sender, EventArgs e)
        {
            RegisterUserControlToPanel();
        }
        #endregion
        
        #region Button
        //다음 버튼 이벤트
        private void btn_next_Click(object sender, EventArgs e)
        {
            // 다음 버튼을 누르면 현재 _screenIndex값에 따라 어떤 usercontrol을 panel로부터 z축 최상위로 보여줄지 정한다. 
            // switch case를 이용해서 만들면 될듯 함.
            switch (_screenIndex)
            {
                case 0:
                    _ucAnalysisWeight.Visible = true;
                    _ucAnalysisWeight.BringToFront();
                    _screenIndex = 1;
                    break;
                case 1:
                    _ucMemberNumber.Visible = true;
                    _ucMemberNumber.BringToFront();
                    _screenIndex = 2;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region UserControl
        //UC_MemberNumbers
        private void OkayButtonClickEvent_MemberNum(object sender, EventArgs e)
        {
            _screenIndex = 3;
            _ucCheckPersonInfo.Visible = true;
            _ucCheckPersonInfo.BringToFront();
        }

        //UC_CheckPersonalInfo
        private void OkayButtonClickEvent_PersonalInfo(object sender, EventArgs e)
        {
            _screenIndex = 4;
            _ucPersonInfoConsent.Visible = true;
            _ucPersonInfoConsent.BringToFront();
        }

        private void YesButtonClickEvent_PersonInfoConsent(object sender, EventArgs e)
        {
            
        }
        
        #endregion

        #endregion

        #region Application Logic
        private void RegisterUserControlToPanel()
        {
            pn_main.Controls.Add(_ucAnalysisWeight);
            pn_main.Controls.Add(_ucMemberNumber);
            pn_main.Controls.Add(_ucCheckPersonInfo);
            pn_main.Controls.Add(_ucPersonInfoConsent);
            pn_main.Controls.Add(_ucPostureFoot);

            _ucAnalysisWeight.Dock = DockStyle.Fill;
            _ucMemberNumber.Dock = DockStyle.Fill;
            _ucCheckPersonInfo.Dock = DockStyle.Fill;
            _ucPersonInfoConsent.Dock = DockStyle.Fill;
            _ucPostureFoot.Dock = DockStyle.Fill;

            _ucAnalysisWeight.Visible = false;
            _ucMemberNumber.Visible = false;
            _ucCheckPersonInfo.Visible = false;
            _ucPersonInfoConsent.Visible = false;
            _ucPostureFoot.Visible = false;
        }

        private void RegisterUserControlEventHandler()
        {
            _ucMemberNumber.OkayButtonClickEvent += this.OkayButtonClickEvent_MemberNum;
            _ucCheckPersonInfo.OkayButtonClickEvent += this.OkayButtonClickEvent_PersonalInfo;
            _ucPersonInfoConsent.YesButtonClickEvent += this.YesButtonClickEvent_PersonInfoConsent;
        }

        #endregion


    }
}



    