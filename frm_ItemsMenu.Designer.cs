namespace Graphics_Engine
{
    partial class frm_ItemsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ItemsMenu));
            this.tv_Items = new System.Windows.Forms.TreeView();
            this.btn_AddNewCuboid = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_Items
            // 
            this.tv_Items.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tv_Items.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_Items.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tv_Items.Location = new System.Drawing.Point(22, 67);
            this.tv_Items.Margin = new System.Windows.Forms.Padding(4);
            this.tv_Items.Name = "tv_Items";
            this.tv_Items.Size = new System.Drawing.Size(486, 614);
            this.tv_Items.TabIndex = 0;
            // 
            // btn_AddNewCuboid
            // 
            this.btn_AddNewCuboid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddNewCuboid.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewCuboid.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddNewCuboid.Location = new System.Drawing.Point(545, 67);
            this.btn_AddNewCuboid.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewCuboid.Name = "btn_AddNewCuboid";
            this.btn_AddNewCuboid.Size = new System.Drawing.Size(222, 70);
            this.btn_AddNewCuboid.TabIndex = 1;
            this.btn_AddNewCuboid.Text = "Add New Cuboid";
            this.btn_AddNewCuboid.UseVisualStyleBackColor = false;
            this.btn_AddNewCuboid.Click += new System.EventHandler(this.btn_AddNewCuboid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shap List :";
            // 
            // frm_ItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(797, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddNewCuboid);
            this.Controls.Add(this.tv_Items);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ItemsMenu";
            this.Text = "Items Menu";
            this.Load += new System.EventHandler(this.frmItemsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Items;
        private System.Windows.Forms.Button btn_AddNewCuboid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}