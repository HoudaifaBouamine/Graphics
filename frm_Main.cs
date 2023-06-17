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
            SetStyle(ControlStyles.SupportsTransparentBackColor,true);
        }

        public static Form Screen;

        private bool isFirstTime = true;

        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {

            if (!isFirstTime) { Screen = new frm_Screen(); }

            if (isFirstTime) isFirstTime = false;
           
            this.Visible = false;
            Screen.ShowDialog();
            this.Visible=true;

        }

        

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Screen = new frm_Screen();
            llbl_SourceCode.BackColor = Color.Transparent;
        }

        private void llbl_SourceCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbl_SourceCode.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/HoudaifaBouamine/Graphics");
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
