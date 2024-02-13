using Inbody.usercontrols.Overview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.Utils
{
    public class UtilExt
    {
        public static void ShowUserControl(UserControl usercontrol)
        {
            usercontrol.Visible = true;
            usercontrol.BringToFront();
        }

        public static void RegisterUserControl(Panel panel, UserControl usercontrol)
        {
            panel.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
            usercontrol.Visible = false;
        }
    }
}
