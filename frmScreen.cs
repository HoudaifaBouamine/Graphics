using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Engine
{
    public partial class frm_Screen : Form
    {
        public frm_Screen()
        {
            InitializeComponent();
        }

   

        private void frmScreen_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            clsApp.app = new clsApp(pb_Screen);
            Fram.Start();
        }

        int counter = 0;

        private void Fram_Tick(object sender, EventArgs e)
        {
            clsApp.app.clear();
            clsApp.app.update();
            clsApp.app.draw();
        }

        private void pb_Screen_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmItemsMenu();
            frm.Show(this);
        }
    }
}
