namespace Graphics_Engine
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_StartSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StartSimulation
            // 
            this.btn_StartSimulation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_StartSimulation.BackgroundImage = global::Graphics_Engine.Properties.Resources.im_btn_Start2;
            this.btn_StartSimulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_StartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartSimulation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_StartSimulation.Location = new System.Drawing.Point(168, 186);
            this.btn_StartSimulation.Name = "btn_StartSimulation";
            this.btn_StartSimulation.Size = new System.Drawing.Size(529, 95);
            this.btn_StartSimulation.TabIndex = 1;
            this.btn_StartSimulation.Text = "Start Simulation";
            this.btn_StartSimulation.UseVisualStyleBackColor = false;
            this.btn_StartSimulation.Click += new System.EventHandler(this.btn_StartSimulation_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Graphics_Engine.Properties.Resources.im_MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 474);
            this.Controls.Add(this.btn_StartSimulation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "Grapics Engine";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartSimulation;
    }
}

