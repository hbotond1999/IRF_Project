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
            if (rendmenny.Text == "" || egysegar.Text == "")
            {
                return;
            }
            else
            {
                decimal a;
                decimal x;
                try
                {
                    a = Convert.ToDecimal(rendmenny.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Kérem számot adjon meg a rendelés mennyiségeként");
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
