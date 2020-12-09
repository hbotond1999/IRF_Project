namespace IRF_projekt
{
    partial class Újrendelés
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
            this.login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.Telefonszam = new System.Windows.Forms.TextBox();
            this.cim = new System.Windows.Forms.TextBox();
            this.rendmenny = new System.Windows.Forms.TextBox();
            this.egysegar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Szul_datum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rend_meny = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Összesen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(120, 39);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(120, 84);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(120, 133);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 4;
            // 
            // Telefonszam
            // 
            this.Telefonszam.Location = new System.Drawing.Point(120, 216);
            this.Telefonszam.Name = "Telefonszam";
            this.Telefonszam.Size = new System.Drawing.Size(100, 20);
            this.Telefonszam.TabIndex = 5;
            // 
            // cim
            // 
            this.cim.Location = new System.Drawing.Point(120, 259);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(100, 20);
            this.cim.TabIndex = 6;
            // 
            // rendmenny
            // 
            this.rendmenny.Location = new System.Drawing.Point(120, 390);
            this.rendmenny.Name = "rendmenny";
            this.rendmenny.Size = new System.Drawing.Size(100, 20);
            this.rendmenny.TabIndex = 9;
            this.rendmenny.Text = "0";
            this.rendmenny.TextChanged += new System.EventHandler(this.Rendmenny_TextChanged);
            // 
            // egysegar
            // 
            this.egysegar.Location = new System.Drawing.Point(120, 431);
            this.egysegar.Name = "egysegar";
            this.egysegar.Size = new System.Drawing.Size(100, 20);
            this.egysegar.TabIndex = 10;
            this.egysegar.Text = "0";
            this.egysegar.TextChanged += new System.EventHandler(this.Rendmenny_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Szul_datum
            // 
            this.Szul_datum.AutoSize = true;
            this.Szul_datum.Location = new System.Drawing.Point(12, 180);
            this.Szul_datum.Name = "Szul_datum";
            this.Szul_datum.Size = new System.Drawing.Size(81, 13);
            this.Szul_datum.TabIndex = 15;
            this.Szul_datum.Text = "Születési dátum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefonszám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cím";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rendelés ideje";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 308);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bicikli",
            "Könyv",
            "Számítógép",
            "Laptop",
            "Labda",
            "Lámpa",
            "Játéautó"});
            this.comboBox1.Location = new System.Drawing.Point(120, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Termék";
            // 
            // rend_meny
            // 
            this.rend_meny.AutoSize = true;
            this.rend_meny.Location = new System.Drawing.Point(12, 397);
            this.rend_meny.Name = "rend_meny";
            this.rend_meny.Size = new System.Drawing.Size(97, 13);
            this.rend_meny.TabIndex = 22;
            this.rend_meny.Text = "Rendelt mennyiség";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Egységár";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Összesen";
            // 
            // Összesen
            // 
            this.Összesen.AutoSize = true;
            this.Összesen.Location = new System.Drawing.Point(130, 471);
            this.Összesen.Name = "Összesen";
            this.Összesen.Size = new System.Drawing.Size(0, 13);
            this.Összesen.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(72, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(190, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 27;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "label10";
            // 
            // Újrendelés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 551);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Összesen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rend_meny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Szul_datum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.egysegar);
            this.Controls.Add(this.rendmenny);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.Telefonszam);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Name = "Újrendelés";
            this.Text = "Újrendelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nev;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox Telefonszam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Szul_datum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rend_meny;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Összesen;
        public System.Windows.Forms.TextBox cim;
        public System.Windows.Forms.TextBox rendmenny;
        public System.Windows.Forms.TextBox egysegar;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}