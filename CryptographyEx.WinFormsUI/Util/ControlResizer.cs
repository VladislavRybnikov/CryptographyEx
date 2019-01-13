using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographyEx.WinFormsUI.Util
{
    public static class ControlResizer
    {
        public static void SetLocationCentred(Control container, Control element)
            => element.Location = new Point((container.Width / 2) - element.Width / 2,
            element.Location.Y);

        public static void SetLocationCentredToParrent(Control control) 
            => SetLocationCentred(control.Parent, control);

        public static void SetYIndentToParrent(Control control, int yIndent)
            => SetControlLocationWithXY(control, control.Location.X, control.Parent.Location.Y + yIndent);

        public static void SetYIndentToParrent(Control control, double percent)
            => SetControlLocationWithXY(control, control.Location.X, 
                control.Parent.Location.Y + (int)(control.Parent.Height - control.Parent.Height * percent));

        public static void SetYIndentToForm(Form form, Control control, double percent)
            => SetControlLocationWithXY(control, control.Location.X, (int)(form.Height * percent));

        public static void SetLocationRight(Control container, Control element)
            => element.Location = new Point(container.Width - element.Width - 10, element.Location.Y);

        public static void SetControlLocationWithXY(Control element, int x, int y) 
            => element.Location = new Point(x, y);

        public static void SetPanelControlLocationWithY(Panel panel, Control element, int y)
            => SetControlLocationWithXY(element, (panel.Width / 2) - element.Width / 2, y);
        
        public static void SetPanelControlLocation(Panel panel, Control element) 
            => SetPanelControlLocationWithY(panel, element, element.Location.Y);
        
        public static void SetControlSize(Control element, int width, int height) 
            => element.Size = new Size(width, height);

    }
}
