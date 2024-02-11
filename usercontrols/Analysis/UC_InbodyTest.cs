using Inbody.Controller;
using Inbody.Models;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols.Analysis
{
    public partial class UC_InbodyTest : UserControl
    {
        private UserInfoModel _currentUser;
        private UserAnalysisModel _currentAnalysis;
        private AnalysisController _analysisController;

        public UC_InbodyTest(UserInfoModel userinfomodel, UserAnalysisModel userAnalysis)
        {
            InitializeComponent();
            _analysisController = new AnalysisController();
            this._currentUser = userinfomodel;
            this._currentAnalysis = userAnalysis;
        }
        #region EventHandler
        #region Load
        private void UC_InbodyTest_Load(object sender, EventArgs e)
        {
            //서버로부터 데이터값 측정값 얻어오기
            _currentAnalysis = _analysisController.GetAnalysisInfo(_currentAnalysis);

            //기본정보
            lbl_memberNum.Text = _currentUser.MemberNum;
            lbl_height.Text = _currentUser.Height.ToString();
            lbl_age.Text = _currentUser.Age.ToString();
            lbl_gender.Text = _currentUser.Gender ? "여자" : "남자";

            //측정 정보
            lbl_weight.Text = _currentAnalysis.Weight.ToString();
            lbl_muscle.Text = _currentAnalysis.SkeletalMuscleMass.ToString();
            lbl_fat.Text = _currentAnalysis.BodyFatMass.ToString();
        }
        #endregion

        #region Button
        private void btn_printInbody_Click(object sender, EventArgs e)
        {
            pn_printResult.Visible = true;
        }
        #endregion

        #region Timer
        private void timer_inbody_Tick(object sender, EventArgs e)
        {
            // 체중
            if (pn_weightProgress.Width < pn_weightProgress.MaximumSize.Width)
            {
                pn_weightProgress.Width += 10;
            }
            
            if (pn_weightProgress.Width >= pn_weightProgress.MaximumSize.Width
                && lbl_progPercent.Text == "100")
            {
                timer_inbody.Stop();
                pn_resultContainer.Controls.Add(pn_result);
                pn_result.Dock = DockStyle.Fill;
                pn_result.Visible = true;
                pn_result.BringToFront();
            }
            // 골격근량
            // 체지방량
        }
        #endregion

        #endregion

        #region Application Logic
        public void TimerStart()
        {
            timer_inbody.Start();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            pn_weightProgress.Width = 0;
            timer_inbody.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = TCPIP_Client.GetDataFromServer("안녕하세요");
            MessageBox.Show(str);
        }
    }
}
