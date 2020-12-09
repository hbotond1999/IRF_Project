using IRF_projekt.Class;
using System;
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

        
    }
}
