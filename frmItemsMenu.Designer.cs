namespace Graphics_Engine
{
    partial class frmItemsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsMenu));
            this.tv_Items = new System.Windows.Forms.TreeView();
            this.btn_AddNewCuboid = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tv_Items
            // 
            this.tv_Items.Location = new System.Drawing.Point(0, 0);
            this.tv_Items.Name = "tv_Items";
            this.tv_Items.Size = new System.Drawing.Size(339, 637);
            this.tv_Items.TabIndex = 0;
            // 
            // btn_AddNewCuboid
            // 
            this.btn_AddNewCuboid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewCuboid.Location = new System.Drawing.Point(355, 12);
            this.btn_AddNewCuboid.Name = "btn_AddNewCuboid";
            this.btn_AddNewCuboid.Size = new System.Drawing.Size(215, 73);
            this.btn_AddNewCuboid.TabIndex = 1;
            this.btn_AddNewCuboid.Text = "Add New Cuboid";
            this.btn_AddNewCuboid.UseVisualStyleBackColor = true;
            this.btn_AddNewCuboid.Click += new System.EventHandler(this.btn_AddNewCuboid_Click);
            // 
            // frmItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(842, 637);
            this.Controls.Add(this.btn_AddNewCuboid);
            this.Controls.Add(this.tv_Items);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 500);
            this.Name = "frmItemsMenu";
            this.Text = "Items Menu";
            this.Load += new System.EventHandler(this.frmItemsMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Items;
        private System.Windows.Forms.Button btn_AddNewCuboid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}