using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class Újrendelés : Form
    {
        public Újrendelés()
        {
            InitializeComponent();
            Számolás();


        }

        private void Rendmenny_TextChanged(object sender, EventArgs e)
        {
            Számolás();
        }


        private void Számolás()
        {
            if (mennyisegButton1.Text == "" || egysegar.Text == "")
            {
                return;
            }
            else
            {
                decimal a;
                decimal x;
                try
                {
                    a = Convert.ToDecimal(mennyisegButton1.Text);
                }
                catch (Exception f)
                {

                    MessageBox.Show(f.Message);
                    return;
                }

                try
                {
                    x = Convert.ToDecimal(egysegar.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Kérem számot adjon meg egységárként");
                    return;
                }

                try
                {
                    label10.Text = (a * x).ToString();
                }
                catch (Exception f)
                {

                    MessageBox.Show(f.Message);
                    return;
                }



            }

        }



        private void Login_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {   //ellenőrzés
            if (!Nemüres(login.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(login, "Adjon meg egy Logint!");
            }
        }

        private void Login_Validated(object sender, EventArgs e)
        {   // skierült validáció
            
            errorProvider1.SetError(login, "");
        }



        private bool Nemüres(string x)
        {
            return !string.IsNullOrEmpty(x);
        }

        private void Nev_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Nemüres(nev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(nev, "Adjon meg egy nevet!");
            }
        }

        private void Nev_Validated(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(nev, "");
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex r = new Regex(@"(^$)|(^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$)");
            if (!r.IsMatch(email.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(email, "Valós e-mail címet adjon meg!");
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void Email_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(email, "");
        }

        private void Telefonszam_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex r = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");
            if (!r.IsMatch(Telefonszam.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Telefonszam, "Valós telefon számot adjon meg!");
            }
            else
            {
                e.Cancel = false;

            }

        }

        private void Telefonszam_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(Telefonszam, "");
        }

        private void Cim_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Nemüres(cim.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cim, "Adjon meg egy címet!");
            }
        }

        private void Cim_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cim, "");
        }

        

       
    }
}
