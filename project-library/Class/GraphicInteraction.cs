using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace project_library.Class
{
    public class GraphicInteraction
    {
        public static void SetColorLabelGreen(Label label)
        {
            label.ForeColor = Color.Green;
        }

        public static void SetColorLabelWhite(Label label)
        {
            label.ForeColor = Color.White;
        }

        public static void SetImageButtonEnter_Half(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Half;
        }

        public static void SetImageButtonLeave_Half(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Half;
        }

        public static void SetImageButtonEnter_Full(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Full;
        }

        public static void SetImageButtonLeave_Full(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Full;
        }

        public static void SetImageButtonEnter_Round(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Round;
        }

        public static void SetImageButtonLeave_Round(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Round;
        }

        public static void SetImageButtonEnter_Square(Button button)
        {
            button.Image = Properties.Resources.imgButtonEntered_Square;
        }

        public static void SetImageButtonLeave_Square(Button button)
        {
            button.Image = Properties.Resources.imgButtonLeft_Square;
        }
    }
}
