namespace Graphics_Engine
{
    partial class frm_AddNewCuboidScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewCuboidScreen));
            this.gb_Position = new System.Windows.Forms.GroupBox();
            this.cb_Position = new System.Windows.Forms.CheckBox();
            this.tb_Position_Z = new System.Windows.Forms.TextBox();
            this.tb_Position_Y = new System.Windows.Forms.TextBox();
            this.tb_Position_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.cb_Size = new System.Windows.Forms.CheckBox();
            this.tb_Size_D = new System.Windows.Forms.TextBox();
            this.tb_Size_H = new System.Windows.Forms.TextBox();
            this.tb_Size_W = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_Rotation = new System.Windows.Forms.GroupBox();
            this.cb_RotationPoint = new System.Windows.Forms.CheckBox();
            this.tb_Rotation_Point_Z = new System.Windows.Forms.TextBox();
            this.tb_Rotation_Point_Y = new System.Windows.Forms.TextBox();
            this.tb_Rotation_Point_X = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Rotation_OZ = new System.Windows.Forms.TextBox();
            this.tb_Rotation_OY = new System.Windows.Forms.TextBox();
            this.tb_Rotation_OX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_Velocity = new System.Windows.Forms.GroupBox();
            this.cb_Velocity = new System.Windows.Forms.CheckBox();
            this.tb_Velocity_DZ = new System.Windows.Forms.TextBox();
            this.tb_Velocity_DY = new System.Windows.Forms.TextBox();
            this.tb_Velocity_DX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_CreateNewItem = new System.Windows.Forms.Button();
            this.gb_Rotation_Center = new System.Windows.Forms.GroupBox();
            this.cb_RotationCenter = new System.Windows.Forms.CheckBox();
            this.tb_Rotation_COZ = new System.Windows.Forms.TextBox();
            this.tb_Rotation_COY = new System.Windows.Forms.TextBox();
            this.tb_Rotation_COX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gb_Position.SuspendLayout();
            this.gb_Size.SuspendLayout();
            this.gb_Rotation.SuspendLayout();
            this.gb_Velocity.SuspendLayout();
            this.gb_Rotation_Center.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Position
            // 
            this.gb_Position.Controls.Add(this.cb_Position);
            this.gb_Position.Controls.Add(this.tb_Position_Z);
            this.gb_Position.Controls.Add(this.tb_Position_Y);
            this.gb_Position.Controls.Add(this.tb_Position_X);
            this.gb_Position.Controls.Add(this.label3);
            this.gb_Position.Controls.Add(this.label2);
            this.gb_Position.Controls.Add(this.label1);
            this.gb_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Position.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Position.Location = new System.Drawing.Point(33, 21);
            this.gb_Position.Name = "gb_Position";
            this.gb_Position.Size = new System.Drawing.Size(241, 202);
            this.gb_Position.TabIndex = 0;
            this.gb_Position.TabStop = false;
            // 
            // cb_Position
            // 
            this.cb_Position.AutoSize = true;
            this.cb_Position.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Position.Checked = true;
            this.cb_Position.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Position.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Position.Location = new System.Drawing.Point(15, 0);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(130, 33);
            this.cb_Position.TabIndex = 0;
            this.cb_Position.Text = "Position";
            this.cb_Position.UseVisualStyleBackColor = false;
            this.cb_Position.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tb_Position_Z
            // 
            this.tb_Position_Z.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Position_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Position_Z.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Position_Z.Location = new System.Drawing.Point(68, 149);
            this.tb_Position_Z.Name = "tb_Position_Z";
            this.tb_Position_Z.Size = new System.Drawing.Size(154, 34);
            this.tb_Position_Z.TabIndex = 3;
            this.tb_Position_Z.Text = "100";
            this.tb_Position_Z.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Position_Y
            // 
            this.tb_Position_Y.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Position_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Position_Y.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Position_Y.Location = new System.Drawing.Point(69, 98);
            this.tb_Position_Y.Name = "tb_Position_Y";
            this.tb_Position_Y.Size = new System.Drawing.Size(154, 34);
            this.tb_Position_Y.TabIndex = 2;
            this.tb_Position_Y.Text = "100";
            this.tb_Position_Y.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Position_X
            // 
            this.tb_Position_X.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Position_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Position_X.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Position_X.Location = new System.Drawing.Point(70, 47);
            this.tb_Position_X.Name = "tb_Position_X";
            this.tb_Position_X.Size = new System.Drawing.Size(154, 34);
            this.tb_Position_X.TabIndex = 1;
            this.tb_Position_X.Text = "100";
            this.tb_Position_X.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // gb_Size
            // 
            this.gb_Size.Controls.Add(this.cb_Size);
            this.gb_Size.Controls.Add(this.tb_Size_D);
            this.gb_Size.Controls.Add(this.tb_Size_H);
            this.gb_Size.Controls.Add(this.tb_Size_W);
            this.gb_Size.Controls.Add(this.label4);
            this.gb_Size.Controls.Add(this.label5);
            this.gb_Size.Controls.Add(this.label6);
            this.gb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Size.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Size.Location = new System.Drawing.Point(33, 240);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Size = new System.Drawing.Size(241, 202);
            this.gb_Size.TabIndex = 1;
            this.gb_Size.TabStop = false;
            // 
            // cb_Size
            // 
            this.cb_Size.AutoSize = true;
            this.cb_Size.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Size.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Size.Location = new System.Drawing.Point(15, 0);
            this.cb_Size.Name = "cb_Size";
            this.cb_Size.Size = new System.Drawing.Size(86, 33);
            this.cb_Size.TabIndex = 4;
            this.cb_Size.Text = "Size";
            this.cb_Size.UseVisualStyleBackColor = false;
            this.cb_Size.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tb_Size_D
            // 
            this.tb_Size_D.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Size_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Size_D.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Size_D.Location = new System.Drawing.Point(70, 150);
            this.tb_Size_D.Name = "tb_Size_D";
            this.tb_Size_D.Size = new System.Drawing.Size(154, 34);
            this.tb_Size_D.TabIndex = 7;
            this.tb_Size_D.Text = "100";
            this.tb_Size_D.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Size_H
            // 
            this.tb_Size_H.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Size_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Size_H.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Size_H.Location = new System.Drawing.Point(70, 99);
            this.tb_Size_H.Name = "tb_Size_H";
            this.tb_Size_H.Size = new System.Drawing.Size(154, 34);
            this.tb_Size_H.TabIndex = 6;
            this.tb_Size_H.Text = "100";
            this.tb_Size_H.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Size_W
            // 
            this.tb_Size_W.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Size_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Size_W.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Size_W.Location = new System.Drawing.Point(70, 48);
            this.tb_Size_W.Name = "tb_Size_W";
            this.tb_Size_W.Size = new System.Drawing.Size(154, 34);
            this.tb_Size_W.TabIndex = 5;
            this.tb_Size_W.Text = "100";
            this.tb_Size_W.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "D :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "H :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "W:";
            // 
            // gb_Rotation
            // 
            this.gb_Rotation.Controls.Add(this.cb_RotationPoint);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_Point_Z);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_Point_Y);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_Point_X);
            this.gb_Rotation.Controls.Add(this.label16);
            this.gb_Rotation.Controls.Add(this.label17);
            this.gb_Rotation.Controls.Add(this.label18);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_OZ);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_OY);
            this.gb_Rotation.Controls.Add(this.tb_Rotation_OX);
            this.gb_Rotation.Controls.Add(this.label7);
            this.gb_Rotation.Controls.Add(this.label8);
            this.gb_Rotation.Controls.Add(this.label9);
            this.gb_Rotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Rotation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Rotation.Location = new System.Drawing.Point(307, 240);
            this.gb_Rotation.Name = "gb_Rotation";
            this.gb_Rotation.Size = new System.Drawing.Size(543, 202);
            this.gb_Rotation.TabIndex = 3;
            this.gb_Rotation.TabStop = false;
            this.gb_Rotation.Enter += new System.EventHandler(this.gb_Rotation_Enter);
            // 
            // cb_RotationPoint
            // 
            this.cb_RotationPoint.AutoSize = true;
            this.cb_RotationPoint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_RotationPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RotationPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_RotationPoint.Location = new System.Drawing.Point(17, 0);
            this.cb_RotationPoint.Name = "cb_RotationPoint";
            this.cb_RotationPoint.Size = new System.Drawing.Size(312, 33);
            this.cb_RotationPoint.TabIndex = 16;
            this.cb_RotationPoint.Text = "Rotation On Other Point";
            this.cb_RotationPoint.UseVisualStyleBackColor = false;
            this.cb_RotationPoint.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tb_Rotation_Point_Z
            // 
            this.tb_Rotation_Point_Z.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_Point_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_Point_Z.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_Point_Z.Location = new System.Drawing.Point(373, 147);
            this.tb_Rotation_Point_Z.Name = "tb_Rotation_Point_Z";
            this.tb_Rotation_Point_Z.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_Point_Z.TabIndex = 22;
            this.tb_Rotation_Point_Z.Text = "0";
            // 
            // tb_Rotation_Point_Y
            // 
            this.tb_Rotation_Point_Y.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_Point_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_Point_Y.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_Point_Y.Location = new System.Drawing.Point(374, 96);
            this.tb_Rotation_Point_Y.Name = "tb_Rotation_Point_Y";
            this.tb_Rotation_Point_Y.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_Point_Y.TabIndex = 21;
            this.tb_Rotation_Point_Y.Text = "0";
            // 
            // tb_Rotation_Point_X
            // 
            this.tb_Rotation_Point_X.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_Point_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_Point_X.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_Point_X.Location = new System.Drawing.Point(375, 45);
            this.tb_Rotation_Point_X.Name = "tb_Rotation_Point_X";
            this.tb_Rotation_Point_X.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_Point_X.TabIndex = 20;
            this.tb_Rotation_Point_X.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(329, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Z :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(329, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "Y :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(329, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "X :";
            // 
            // tb_Rotation_OZ
            // 
            this.tb_Rotation_OZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_OZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_OZ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_OZ.Location = new System.Drawing.Point(87, 150);
            this.tb_Rotation_OZ.Name = "tb_Rotation_OZ";
            this.tb_Rotation_OZ.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_OZ.TabIndex = 19;
            this.tb_Rotation_OZ.Text = "0";
            this.tb_Rotation_OZ.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Rotation_OY
            // 
            this.tb_Rotation_OY.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_OY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_OY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_OY.Location = new System.Drawing.Point(87, 99);
            this.tb_Rotation_OY.Name = "tb_Rotation_OY";
            this.tb_Rotation_OY.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_OY.TabIndex = 18;
            this.tb_Rotation_OY.Text = "0";
            this.tb_Rotation_OY.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Rotation_OX
            // 
            this.tb_Rotation_OX.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_OX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_OX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_OX.Location = new System.Drawing.Point(87, 48);
            this.tb_Rotation_OX.Name = "tb_Rotation_OX";
            this.tb_Rotation_OX.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_OX.TabIndex = 17;
            this.tb_Rotation_OX.Text = "0";
            this.tb_Rotation_OX.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "OZ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "OY :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "OX :";
            // 
            // gb_Velocity
            // 
            this.gb_Velocity.Controls.Add(this.cb_Velocity);
            this.gb_Velocity.Controls.Add(this.tb_Velocity_DZ);
            this.gb_Velocity.Controls.Add(this.tb_Velocity_DY);
            this.gb_Velocity.Controls.Add(this.tb_Velocity_DX);
            this.gb_Velocity.Controls.Add(this.label10);
            this.gb_Velocity.Controls.Add(this.label11);
            this.gb_Velocity.Controls.Add(this.label12);
            this.gb_Velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Velocity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Velocity.Location = new System.Drawing.Point(307, 21);
            this.gb_Velocity.Name = "gb_Velocity";
            this.gb_Velocity.Size = new System.Drawing.Size(255, 202);
            this.gb_Velocity.TabIndex = 2;
            this.gb_Velocity.TabStop = false;
            // 
            // cb_Velocity
            // 
            this.cb_Velocity.AutoSize = true;
            this.cb_Velocity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Velocity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Velocity.Location = new System.Drawing.Point(17, 0);
            this.cb_Velocity.Name = "cb_Velocity";
            this.cb_Velocity.Size = new System.Drawing.Size(127, 33);
            this.cb_Velocity.TabIndex = 8;
            this.cb_Velocity.Text = "Velocity";
            this.cb_Velocity.UseVisualStyleBackColor = false;
            this.cb_Velocity.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tb_Velocity_DZ
            // 
            this.tb_Velocity_DZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Velocity_DZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Velocity_DZ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Velocity_DZ.Location = new System.Drawing.Point(87, 149);
            this.tb_Velocity_DZ.Name = "tb_Velocity_DZ";
            this.tb_Velocity_DZ.Size = new System.Drawing.Size(154, 34);
            this.tb_Velocity_DZ.TabIndex = 11;
            this.tb_Velocity_DZ.Text = "0";
            this.tb_Velocity_DZ.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Velocity_DY
            // 
            this.tb_Velocity_DY.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Velocity_DY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Velocity_DY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Velocity_DY.Location = new System.Drawing.Point(88, 98);
            this.tb_Velocity_DY.Name = "tb_Velocity_DY";
            this.tb_Velocity_DY.Size = new System.Drawing.Size(154, 34);
            this.tb_Velocity_DY.TabIndex = 10;
            this.tb_Velocity_DY.Text = "0";
            this.tb_Velocity_DY.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // tb_Velocity_DX
            // 
            this.tb_Velocity_DX.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Velocity_DX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Velocity_DX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Velocity_DX.Location = new System.Drawing.Point(89, 47);
            this.tb_Velocity_DX.Name = "tb_Velocity_DX";
            this.tb_Velocity_DX.Size = new System.Drawing.Size(154, 34);
            this.tb_Velocity_DX.TabIndex = 9;
            this.tb_Velocity_DX.Text = "0";
            this.tb_Velocity_DX.TextChanged += new System.EventHandler(this.ReadOnlyNumbers);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "dZ :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "dY :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "dX :";
            // 
            // btn_CreateNewItem
            // 
            this.btn_CreateNewItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateNewItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CreateNewItem.Location = new System.Drawing.Point(33, 462);
            this.btn_CreateNewItem.Name = "btn_CreateNewItem";
            this.btn_CreateNewItem.Size = new System.Drawing.Size(817, 66);
            this.btn_CreateNewItem.TabIndex = 23;
            this.btn_CreateNewItem.Text = "Create New Item";
            this.btn_CreateNewItem.UseVisualStyleBackColor = false;
            this.btn_CreateNewItem.Click += new System.EventHandler(this.btn_CreateNewItem_Click);
            // 
            // gb_Rotation_Center
            // 
            this.gb_Rotation_Center.Controls.Add(this.cb_RotationCenter);
            this.gb_Rotation_Center.Controls.Add(this.tb_Rotation_COZ);
            this.gb_Rotation_Center.Controls.Add(this.tb_Rotation_COY);
            this.gb_Rotation_Center.Controls.Add(this.tb_Rotation_COX);
            this.gb_Rotation_Center.Controls.Add(this.label13);
            this.gb_Rotation_Center.Controls.Add(this.label14);
            this.gb_Rotation_Center.Controls.Add(this.label15);
            this.gb_Rotation_Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Rotation_Center.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Rotation_Center.Location = new System.Drawing.Point(595, 21);
            this.gb_Rotation_Center.Name = "gb_Rotation_Center";
            this.gb_Rotation_Center.Size = new System.Drawing.Size(255, 202);
            this.gb_Rotation_Center.TabIndex = 7;
            this.gb_Rotation_Center.TabStop = false;
            // 
            // cb_RotationCenter
            // 
            this.cb_RotationCenter.AutoSize = true;
            this.cb_RotationCenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_RotationCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RotationCenter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_RotationCenter.Location = new System.Drawing.Point(15, 0);
            this.cb_RotationCenter.Name = "cb_RotationCenter";
            this.cb_RotationCenter.Size = new System.Drawing.Size(217, 33);
            this.cb_RotationCenter.TabIndex = 12;
            this.cb_RotationCenter.Text = "Rotation Center";
            this.cb_RotationCenter.UseVisualStyleBackColor = false;
            this.cb_RotationCenter.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tb_Rotation_COZ
            // 
            this.tb_Rotation_COZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_COZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_COZ.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_COZ.Location = new System.Drawing.Point(87, 150);
            this.tb_Rotation_COZ.Name = "tb_Rotation_COZ";
            this.tb_Rotation_COZ.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_COZ.TabIndex = 15;
            this.tb_Rotation_COZ.Text = "0.01";
            // 
            // tb_Rotation_COY
            // 
            this.tb_Rotation_COY.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_COY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_COY.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_COY.Location = new System.Drawing.Point(87, 99);
            this.tb_Rotation_COY.Name = "tb_Rotation_COY";
            this.tb_Rotation_COY.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_COY.TabIndex = 14;
            this.tb_Rotation_COY.Text = "0.01";
            // 
            // tb_Rotation_COX
            // 
            this.tb_Rotation_COX.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_Rotation_COX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rotation_COX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Rotation_COX.Location = new System.Drawing.Point(87, 48);
            this.tb_Rotation_COX.Name = "tb_Rotation_COX";
            this.tb_Rotation_COX.Size = new System.Drawing.Size(154, 34);
            this.tb_Rotation_COX.TabIndex = 13;
            this.tb_Rotation_COX.Text = "0.01";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "OZ :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "OY :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "OX :";
            // 
            // frm_AddNewCuboidScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(882, 554);
            this.Controls.Add(this.gb_Rotation_Center);
            this.Controls.Add(this.btn_CreateNewItem);
            this.Controls.Add(this.gb_Rotation);
            this.Controls.Add(this.gb_Velocity);
            this.Controls.Add(this.gb_Size);
            this.Controls.Add(this.gb_Position);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddNewCuboidScreen";
            this.Text = "Add new Cuboid";
            this.Load += new System.EventHandler(this.frm_AddNewCuboidScreen_Load);
            this.gb_Position.ResumeLayout(false);
            this.gb_Position.PerformLayout();
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            this.gb_Rotation.ResumeLayout(false);
            this.gb_Rotation.PerformLayout();
            this.gb_Velocity.ResumeLayout(false);
            this.gb_Velocity.PerformLayout();
            this.gb_Rotation_Center.ResumeLayout(false);
            this.gb_Rotation_Center.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Position;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Position_Z;
        private System.Windows.Forms.TextBox tb_Position_Y;
        private System.Windows.Forms.TextBox tb_Position_X;
        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.TextBox tb_Size_D;
        private System.Windows.Forms.TextBox tb_Size_H;
        private System.Windows.Forms.TextBox tb_Size_W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_Rotation;
        private System.Windows.Forms.TextBox tb_Rotation_OZ;
        private System.Windows.Forms.TextBox tb_Rotation_OY;
        private System.Windows.Forms.TextBox tb_Rotation_OX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_Velocity;
        private System.Windows.Forms.TextBox tb_Velocity_DZ;
        private System.Windows.Forms.TextBox tb_Velocity_DY;
        private System.Windows.Forms.TextBox tb_Velocity_DX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_CreateNewItem;
        private System.Windows.Forms.TextBox tb_Rotation_Point_Z;
        private System.Windows.Forms.TextBox tb_Rotation_Point_Y;
        private System.Windows.Forms.TextBox tb_Rotation_Point_X;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gb_Rotation_Center;
        private System.Windows.Forms.TextBox tb_Rotation_COZ;
        private System.Windows.Forms.TextBox tb_Rotation_COY;
        private System.Windows.Forms.TextBox tb_Rotation_COX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cb_Position;
        private System.Windows.Forms.CheckBox cb_Velocity;
        private System.Windows.Forms.CheckBox cb_RotationCenter;
        private System.Windows.Forms.CheckBox cb_Size;
        private System.Windows.Forms.CheckBox cb_RotationPoint;
    }
}