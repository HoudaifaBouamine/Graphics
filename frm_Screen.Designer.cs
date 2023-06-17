namespace Graphics_Engine
{
    partial class frm_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Screen));
            this.pb_Screen = new System.Windows.Forms.PictureBox();
            this.Fram = new System.Windows.Forms.Timer(this.components);
            this.btn_AddNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Screen
            // 
            this.pb_Screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Screen.Location = new System.Drawing.Point(0, 0);
            this.pb_Screen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pb_Screen.Name = "pb_Screen";
            this.pb_Screen.Size = new System.Drawing.Size(1080, 669);
            this.pb_Screen.TabIndex = 0;
            this.pb_Screen.TabStop = false;
            this.pb_Screen.Click += new System.EventHandler(this.pb_Screen_Click);
            // 
            // Fram
            // 
            this.Fram.Interval = 32;
            this.Fram.Tick += new System.EventHandler(this.Fram_Tick);
            // 
            // btn_AddNewItem
            // 
            this.btn_AddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNewItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddNewItem.Location = new System.Drawing.Point(877, 14);
            this.btn_AddNewItem.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(188, 56);
            this.btn_AddNewItem.TabIndex = 2;
            this.btn_AddNewItem.Text = "Add New Item";
            this.btn_AddNewItem.UseVisualStyleBackColor = false;
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // frm_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1080, 669);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.pb_Screen);
            this.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_Screen";
            this.Text = "Graphics Screen";
            this.Load += new System.EventHandler(this.frmScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Screen;
        private System.Windows.Forms.Button btn_AddNewItem;
        public System.Windows.Forms.Timer Fram;
    }
}