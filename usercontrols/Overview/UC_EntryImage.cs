using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols.Overview
{
    public partial class UC_EntryImage : UserControl
    {
        private int _timerCount = 0;
        public UC_EntryImage()
        {
            InitializeComponent();
        }

        #region EventHandler

        #region Timer
        private void timer_entryimage_Tick(object sender, EventArgs e)
        {
            _timerCount += 1;
            if (_timerCount == 2)
            {
                timer_entryimage.Stop();
                this.Dispose();
            }
        }
        #endregion

        #endregion

        #region Application Logic
        public void StartLogicTimer()
        {
            timer_entryimage.Start();
        }
        #endregion

        
    }
}
