using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Graphics_Engine
{
    public partial class frm_AddNewCuboidScreen : Form
    {
        public frm_AddNewCuboidScreen()
        {
            InitializeComponent();
        }

        private clsVector getPoint(TextBox t1,TextBox t2,TextBox t3)
        {
            return new clsVector(Convert.ToSingle(t1.Text), Convert.ToSingle(t2.Text), Convert.ToSingle(t3.Text));

        }

        private void btn_CreateNewItem_Click(object sender, EventArgs e)
        {
            if (!check_if_all_info_exist())
            {
                MessageBox.Show("Enter All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialog_Result = MessageBox.Show("Are you sure you want to add this Cuboid ?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialog_Result == DialogResult.Yes)
            {

                clsVector pos = getPoint(tb_Position_X, tb_Position_Y, tb_Position_Z);
                clsVector size = getPoint(tb_Size_W, tb_Size_H, tb_Size_D);
                clsVector velocity = getPoint(tb_Velocity_DX, tb_Velocity_DY, tb_Velocity_DZ);
                clsVector rotation_on_point_velocity = getPoint(tb_Rotation_OX, tb_Rotation_OY, tb_Rotation_OZ);
                clsVector rotation_on_point_xyz = getPoint(tb_Rotation_Point_X, tb_Rotation_Point_Y, tb_Rotation_Point_Z);
                clsVector rotation_on_center_velocity = getPoint(tb_Rotation_COX, tb_Rotation_COY, tb_Rotation_COZ);
                clsUpdate update_args = new clsUpdate(velocity, rotation_on_point_velocity,rotation_on_center_velocity);
                update_args.b_rotate_center = true;
                update_args.b_rotate_point = true;
                update_args.rotate_point = rotation_on_point_xyz;

                clsShap new_Cuboid = clsShap.CreateCuboid(pos, size, update_args);
                clsApp.app.shaps.Add(new_Cuboid);

            }

        }


        private bool check_if_all_info_exist()
        {

            if(tb_Position_X.Text != "" &&
               tb_Position_Y.Text != "" &&
               tb_Position_Z.Text != "" &&
               tb_Size_W.Text != "" &&
               tb_Size_H.Text != "" &&
               tb_Size_D.Text != "" &&
              tb_Velocity_DX.Text != "" &&
              tb_Velocity_DY.Text != "" &&
              tb_Velocity_DZ.Text != "" &&
              tb_Rotation_OX.Text != "" &&
              tb_Rotation_OY.Text != "" &&
              tb_Rotation_OZ.Text != "")
                return true;


            return false;
        }

        private void ReadOnlyNumbers(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            string tmp_text = "";

            for(int i = 0; i < text.Length;i++)
            {

                if (text[i] <= '9' && text[i] >= '0' || text[i] == '.')
                {
                    tmp_text += text[i];
                }

            }


            ((TextBox)sender).Text = tmp_text;
        }

        private void gb_Rotation_Enter(object sender, EventArgs e)
        {

        }

        private void enable_and_disable_options()
        {

            if(cb_Position.Checked)
            {
                tb_Position_X.Enabled = true;
                tb_Position_Y.Enabled = true;
                tb_Position_Z.Enabled = true;

            }
            else
            {
                tb_Position_X.Enabled = false;
                tb_Position_Y.Enabled = false;
                tb_Position_Z.Enabled = false;

            }

            if (cb_Size.Checked)
            {
                tb_Size_W.Enabled = true;
                tb_Size_H.Enabled = true;
                tb_Size_D.Enabled = true;

            }
            else
            {
                tb_Size_W.Enabled = false;
                tb_Size_H.Enabled = false;
                tb_Size_D.Enabled = false;

            }


            if (cb_Velocity.Checked)
            {
               
                tb_Velocity_DX.Enabled = true;
                tb_Velocity_DY.Enabled = true;
                tb_Velocity_DZ.Enabled = true;

            }
            else
            {
                tb_Velocity_DX.Enabled = false;
                tb_Velocity_DY.Enabled = false;
                tb_Velocity_DZ.Enabled = false;


            }


            if (cb_RotationCenter.Checked)
            {

                tb_Rotation_COX.Enabled = true;
                tb_Rotation_COY.Enabled = true;
                tb_Rotation_COZ.Enabled = true;

            }
            else
            {
                tb_Rotation_COX.Enabled = false;
                tb_Rotation_COY.Enabled = false;
                tb_Rotation_COZ.Enabled = false;

            }


            if (cb_RotationPoint.Checked)
            {

                tb_Rotation_OX.Enabled = true;
                tb_Rotation_OY.Enabled = true;
                tb_Rotation_OZ.Enabled = true;

                tb_Rotation_Point_X.Enabled = true;
                tb_Rotation_Point_Y.Enabled = true;
                tb_Rotation_Point_Z.Enabled = true;
            }
            else
            {
                tb_Rotation_OX.Enabled = false;
                tb_Rotation_OY.Enabled = false;
                tb_Rotation_OZ.Enabled = false;

                tb_Rotation_Point_X.Enabled = false;
                tb_Rotation_Point_Y.Enabled = false;
                tb_Rotation_Point_Z.Enabled = false;
            }

        }

        private void frm_AddNewCuboidScreen_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Owner.Location.X - 100, this.Owner.Location.Y + this.Owner.Size.Height/2);
            enable_and_disable_options();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            enable_and_disable_options();
        }
    }
}
