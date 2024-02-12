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
        private AnalysisUseCase _analysisController;

        private double _weightPerWidth = 0;
        private double _muscleMassPerWidth = 0;
        private double _bodyFatPercentPerWidth = 0;

        public UC_InbodyTest(UserInfoModel userinfomodel, UserAnalysisModel userAnalysis)
        {
            InitializeComponent();
            _analysisController = new AnalysisUseCase();
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

            //db저장 로직
            _analysisController.SaveUserAnalysis(_currentUser, _currentAnalysis);

            pn_printResult.Visible = false;
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

            if (int.Parse(lbl_progPercent.Text) < 100)
            {
                var percent = int.Parse(lbl_progPercent.Text);
                lbl_progPercent.Text = (percent + 5).ToString();
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

        private void timer_weight_Tick(object sender, EventArgs e)
        {
            if (pn_weightProgress.Width >= _currentAnalysis.Weight * _weightPerWidth)
            {
                timer_weight.Stop();
                var percent = int.Parse(lbl_progPercent.Text);
                lbl_progPercent.Text = (percent + 30).ToString();
            }
            pn_weightProgress.Width += 1; 
        }
        #endregion

        #endregion

        #region Application Logic
        public void TimerStart()
        {
            timer_inbody.Start();
        }

        private async Task StartMuscleMassAnalysis()
        {
            _muscleMassPerWidth = _analysisController.GetMuscleMasstPerWidth(_currentUser, pn_muscle.Width / 12 * 4);
            await Task.Run(async () => {
                while (pn_muscleProgress.Width < _currentAnalysis.SkeletalMuscleMass * _muscleMassPerWidth)
                {
                    Invoke(new Action(() =>
                    {
                        pn_muscleProgress.Width += 1;
                    }));
                    await Task.Delay(10);
                }
            });

            var percent = int.Parse(lbl_progPercent.Text);
            lbl_progPercent.Text = (percent + 35).ToString();
        }

        private async Task StartBodyFatPercentAnalysis()
        {
            _bodyFatPercentPerWidth = _analysisController.GetBodyFatPercentPerWidth(_currentUser, pn_muscle.Width / 12 * 4);
            var userBodyFatPercent = _currentAnalysis.BodyFatMass / _currentAnalysis.Weight * 100;
            await Task.Run(async () =>
            {
                while (pn_fatProgress.Width < userBodyFatPercent * _bodyFatPercentPerWidth)
                {
                    Invoke(new Action(() =>
                    {
                        pn_fatProgress.Width += 1;
                    }));
                    await Task.Delay(10);
                }
            });

            var percent = int.Parse(lbl_progPercent.Text);
            lbl_progPercent.Text = (percent + 35).ToString();
        }

        public async Task InbodyTestStart()
        {
            _weightPerWidth = _analysisController.GetWeightPerWidth(_currentUser, pn_weight.Width / 12 * 4);
            timer_weight.Start();
            await StartMuscleMassAnalysis();
            await StartBodyFatPercentAnalysis();

            //결과 버튼 Show
            pn_resultContainer.Controls.Add(pn_result);
            pn_result.Dock = DockStyle.Fill;
            pn_result.Visible = true;
            pn_result.BringToFront();
        }
        #endregion


        #region Test
        private void button1_Click(object sender, EventArgs e)
        {
            //pn_weightProgress.Width = 0;
            //timer_inbody.Start();
            Console.WriteLine(pn_weightProgress.Width);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            StartBodyFatPercentAnalysis();
        }
        #endregion





    }
}
