using Inbody.Controller;
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
    public partial class UC_AnalysisWeight : UserControl
    {
        public event EventHandler<EventWeightArgs> WeightEventHandler;

        private AnalysisController _analysisController;

        public UC_AnalysisWeight()
        {
            InitializeComponent();
            _analysisController = new AnalysisController();
        }

        private void timer_weight_Tick(object sender, EventArgs e)
        {
            WeightEventHandler?.Invoke(sender, new EventWeightArgs(double.Parse(lbl_weight.Text)));
            timer_weight.Stop();
        }

        public void StartTimer()
        {
            timer_weight.Start();
        }

        public void GetWeightFromServer(string msg)
        {
            // 서버에서 Weight값을 가져온다.
            var weight = _analysisController.GetWeight(msg);
            // lbl_weight값을 변경시킨다.
            lbl_weight.Text = weight;
            // timer를 실행시킨다. 
            timer_weight.Start();
        }
    }

    public class EventWeightArgs
    {
        public double Weight { get; set; }

        public EventWeightArgs(double weight)
        {
            this.Weight = weight;
        }
    }
}
