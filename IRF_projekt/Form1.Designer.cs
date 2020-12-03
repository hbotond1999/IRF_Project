namespace IRF_projekt
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.Button();
            this.Adatok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(167, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 515);
            this.panel1.TabIndex = 0;
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(12, 28);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(100, 36);
            this.home_button.TabIndex = 1;
            this.home_button.Text = "Home";
            this.home_button.UseCompatibleTextRendering = true;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Adatok
            // 
            this.Adatok.Location = new System.Drawing.Point(12, 86);
            this.Adatok.Name = "Adatok";
            this.Adatok.Size = new System.Drawing.Size(100, 36);
            this.Adatok.TabIndex = 2;
            this.Adatok.Text = "Adatok";
            this.Adatok.UseVisualStyleBackColor = true;
            this.Adatok.Click += new System.EventHandler(this.Adatok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.Adatok);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button Adatok;
    }
}

