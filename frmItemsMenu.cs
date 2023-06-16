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
    public partial class frmItemsMenu : Form
    {
        public frmItemsMenu()
        {
            InitializeComponent();
        }

        

        private void frmItemsMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Owner.Location.X + this.Owner.Size.Width, 0);

            tv_Items.Nodes.Add(frm_Main.Screen.Text);
        }


        private void AddNewCuboid()
        {
            Form frm = new frm_AddNewCuboidScreen();
            frm.Show(this);
        }

        private void btn_AddNewCuboid_Click(object sender, EventArgs e)
        {
            AddNewCuboid();
        }
    }
}
