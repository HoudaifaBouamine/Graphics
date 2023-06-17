using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Engine
{
    public partial class frm_ItemsMenu : Form
    {
        public frm_ItemsMenu()
        {
            InitializeComponent();
        }

        

        private void frmItemsMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Owner.Location.X + this.Owner.Size.Width, 0);

           // tv_Items.Nodes.Add(frm_Main.Screen.Text);
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

        private void AddShapToTreeView(clsShap shap)
        {
            TreeNode node = new TreeNode();
            node.Text = shap.name;

            TreeNode pointNode = new TreeNode();
            pointNode.Text = "Center " + " {" + shap.center.x.ToString() + " ," + shap.center.y.ToString() + " ," + shap.center.z.ToString() + " }";

            TreeNode xyzNode = new TreeNode();
            xyzNode.Text = "X = " + shap.center.x.ToString();
            pointNode.Nodes.Add(xyzNode);
            xyzNode.Text = "Y = " + shap.center.y.ToString();
            pointNode.Nodes.Add(xyzNode);
            xyzNode.Text = "Z = " + shap.center.z.ToString();
            pointNode.Nodes.Add(xyzNode);
            node.Nodes.Add(pointNode);


            for (int i = 0; i < shap.points.Count; i++) { 

                 pointNode = new TreeNode();

                pointNode.Text = "Point " + Convert.ToString(i + 1) + " {" + shap.points[i].x.ToString() + " ," + shap.points[i].y.ToString() + " ," + shap.points[i].z.ToString() + " }";

                 xyzNode = new TreeNode();
                xyzNode.Text = "X = " + shap.points[i].x.ToString();
                pointNode.Nodes.Add(xyzNode);

                 xyzNode = new TreeNode();
                xyzNode.Text = "Y = " + shap.points[i].y.ToString();
                pointNode.Nodes.Add(xyzNode);

                 xyzNode = new TreeNode();
                xyzNode.Text = "Z = " + shap.points[i].z.ToString();
                pointNode.Nodes.Add(xyzNode);

                node.Nodes.Add(pointNode);
            }

            

            tv_Items.Nodes.Add(node);
            
        }

      

        public void updateTreeView()
        {


            if (clsApp.app.flags.new_shap_to_tree_view)
            {
                AddShapToTreeView(clsApp.app.shaps[clsApp.app.shaps.Count - 1]);
                clsApp.app.flags.new_shap_to_tree_view = false;
            }

            for (int j = 0 ; j < tv_Items.Nodes.Count;j++)
            {
                clsShap shap = clsApp.app.shaps[j];
                tv_Items.Nodes[j].Text = shap.name;


                tv_Items.Nodes[j].Nodes[0].Text = "Center " + " {" + shap.center.x.ToString() + " ," + shap.center.y.ToString() + " ," + shap.center.z.ToString() + " }";
                tv_Items.Nodes[j].Nodes[0].Nodes[0].Text = "X = " + shap.center.x.ToString();
                tv_Items.Nodes[j].Nodes[0].Nodes[1].Text = "Y = " + shap.center.y.ToString();
                tv_Items.Nodes[j].Nodes[0].Nodes[2].Text = "Z = " + shap.center.z.ToString();

                for (int i = 0; i < shap.points.Count; i++)
                {

                    tv_Items.Nodes[j].Nodes[i+1].Text = "Point " + Convert.ToString(i + 1) + " {" + ((int)shap.points[i].x).ToString() + " ," + ((int)shap.points[i].y).ToString() + " ," + ((int)shap.points[i].z).ToString() + " }";
                    tv_Items.Nodes[j].Nodes[i+1].Nodes[0].Text = "X = " + shap.points[i].x.ToString();
                    tv_Items.Nodes[j].Nodes[i+1].Nodes[1].Text = "Y = " + shap.points[i].y.ToString();
                    tv_Items.Nodes[j].Nodes[i+1].Nodes[2].Text = "Z = " + shap.points[i].z.ToString();

                }
            }
        }

    }
}
