using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbody.Utils
{
    public class Pallete
    {
        private static Color _InbodyRed = ColorTranslator.FromHtml("#ac0430");

        public static Color InbodyRed
        {
            get
            {
                return _InbodyRed;
            }
        }

    }
}
