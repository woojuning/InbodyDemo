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
    public partial class UC_PersonalInfoConsent : UserControl
    {
        public event EventHandler YesButtonClickEvent;

        public UC_PersonalInfoConsent()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            YesButtonClickEvent?.Invoke(sender, e);
        }
    }
}
