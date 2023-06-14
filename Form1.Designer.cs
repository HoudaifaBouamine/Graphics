namespace Graphics_Render
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
            this.Fram = new System.Windows.Forms.Timer(this.components);
            this.pb_drawing = new System.Windows.Forms.PictureBox();
            this.lbl_MousePos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drawing)).BeginInit();
            this.SuspendLayout();
            // 
            // Fram
            // 
            this.Fram.Interval = 32;
            this.Fram.Tick += new System.EventHandler(this.Fram_Tick);
            // 
            // pb_drawing
            // 
            this.pb_drawing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_drawing.Location = new System.Drawing.Point(12, 12);
            this.pb_drawing.Name = "pb_drawing";
            this.pb_drawing.Size = new System.Drawing.Size(671, 612);
            this.pb_drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_drawing.TabIndex = 0;
            this.pb_drawing.TabStop = false;
            this.pb_drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_draw_MouseMove);
            // 
            // lbl_MousePos
            // 
            this.lbl_MousePos.AutoSize = true;
            this.lbl_MousePos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_MousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MousePos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MousePos.Location = new System.Drawing.Point(21, 589);
            this.lbl_MousePos.Name = "lbl_MousePos";
            this.lbl_MousePos.Size = new System.Drawing.Size(0, 20);
            this.lbl_MousePos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // frm_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MousePos);
            this.Controls.Add(this.pb_drawing);
            this.Name = "frm_Screen";
            this.Text = "Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_drawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Fram;
        private System.Windows.Forms.PictureBox pb_drawing;
        private System.Windows.Forms.Label lbl_MousePos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

