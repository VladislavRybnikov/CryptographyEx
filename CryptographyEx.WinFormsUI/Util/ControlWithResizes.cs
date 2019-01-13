using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyEx.WinFormsUI.Util
{
    public class ControlWithResizes
    {
        public Control Control { get; set; }
        public List<Action<Control>> Resizes { get; set; } = new List<Action<Control>>();

        public void Resize() => Resizes?.ForEach(resize 
            => {
                if (Control != null)
                {
                    try
                    {
                        resize(Control);
                    }
                    catch
                    {

                    }
                }
            });
    }
}
