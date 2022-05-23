using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHoa;
//using Syncfusion.Windows.Forms.Tools;
namespace QuanLyBanHoa.Forms
{
    public partial class Setting : Form
    {
        private MainScreen main = null;
        public Setting(Form callingForm)
        {
            main = callingForm as MainScreen;
            InitializeComponent();
            
        }
        private struct RGB
        {
            //Green
            public static Color color1 = Color.FromArgb(13, 139, 57);
            //Red
            public static Color color2 = Color.FromArgb(247, 22, 52);
            //Violet
            public static Color color3 = Color.FromArgb(169, 3, 210);
            //Blue
            public static Color color4 = Color.FromArgb(0, 19, 234);
            //White
            public static Color color5 = Color.FromArgb(255, 255, 255);
            //Black
            public static Color color6 = Color.FromArgb(0, 0, 0);
        }
        Color color = new Color();
        public delegate void PassControl(object sender);
        public PassControl passControl;
        private void send()
        {
            if (passControl != null)
            {
                passControl(color);
            }
        }
        
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color2;
            send();
            this.main.changePanelColor(color);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color3;
            send();
            this.main.changePanelColor(color);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color4;
            send();
            this.main.changePanelColor(color);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color5;
            send();
            this.main.changePanelColor(color);
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color1;
            send();
            this.main.changePanelColor(color);
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = RGB.color6;
            send();
            this.main.changePanelColor(color);
        }
    }
}
