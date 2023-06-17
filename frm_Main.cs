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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        public static Form Screen;

        private bool isFirstTime = true;

        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {

            if(!isFirstTime) Screen = new frm_Screen();

            if (isFirstTime) isFirstTime = false;
           
            Screen.Show();
        }

        

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Screen = new frm_Screen();
        }
    }
}
