using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printscreener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string path = "D:\\ScreenShotTemp.gif";
            ScreenCapture sc = new ScreenCapture();
            
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            
            // display image in a Picture control named imageDisplay
            this.pictureBox1.Image = img;

            lbl_path.Text = "Your file is here : " + path + "\n Printsreen on " + DateTime.Now.ToShortDateString();
            // capture this window, and save it
            sc.CaptureWindowToFile(this.Handle, path, ImageFormat.Gif);

        }
    }
}
