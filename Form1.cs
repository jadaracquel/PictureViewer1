using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //**Add Event Handlers**
        private void showPic_btn_Click(object sender, EventArgs e)
        {
            //Open file explorer and load whatever file the user chooses
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearPic_btn_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox1.Image = null;
        }

        private void bgColor_btn_Click(object sender, EventArgs e)
        {
            //Show the color diallog box; if the user clicks OK, change the
            //pictureBox1 background to the color the user chose
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* If the user selects the Stretch check box, change the pictureBox's
             * sizeMode property to "Stretch"; if the user unchecks the check
             * box, change the sizeMode property to 'Normal"     */
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } 
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
           
        }
    }
}
