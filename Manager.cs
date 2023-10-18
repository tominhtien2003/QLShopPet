using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopPet
{
    public partial class Manager : Form
    {
        string fileanh;
        public Manager()
        {
            InitializeComponent();
        }

        private void pHỤKIỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            fileanh = "taicup.jpg";
            try
            {
                PicCupBeo.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhMeo\\" + fileanh);
            }
            catch { 
                PicCupBeo.Image=null;
            }
            fileanh = "meoanh.jpg";
            try
            {
                PicAnhNgan.Image= Image.FromFile(Application.StartupPath + "\\Images\\AnhMeo\\" + fileanh);
            }
            catch
            {
                PicAnhNgan.Image = null;
            }
            fileanh = "meomuop.jpg";
            try
            {
                PicMuop.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhMeo\\" + fileanh);
            }
            catch
            {
                PicMuop.Image = null;
            }
            fileanh = "taicupcute.jpg";
            try
            {
                Piccupcute.Image = Image.FromFile(Application.StartupPath + "\\Images\\AnhMeo\\" + fileanh);
            }
            catch
            {
                Piccupcute.Image = null;
            }
        }

        private void groupBoxSPMoi_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point(
            (panel1.Width - label1.Width) / 2,
            (panel1.Height - label1.Height) / 2);
        }
    }
}
