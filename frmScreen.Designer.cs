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
            this.pb_Screen.Name = "pb_Screen";
            this.pb_Screen.Size = new System.Drawing.Size(1086, 772);
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
            this.btn_AddNewItem.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewItem.Location = new System.Drawing.Point(888, 12);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(186, 50);
            this.btn_AddNewItem.TabIndex = 2;
            this.btn_AddNewItem.Text = "Add New Item";
            this.btn_AddNewItem.UseVisualStyleBackColor = true;
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // frm_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 772);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.pb_Screen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Screen";
            this.Text = "Graphics Screen";
            this.Load += new System.EventHandler(this.frmScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Screen;
        private System.Windows.Forms.Timer Fram;
        private System.Windows.Forms.Button btn_AddNewItem;
    }
}