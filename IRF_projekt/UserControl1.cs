using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class UserControl1 : UserControl
    {
        //private List<Webshop> webshops = new List<Webshop>();
        BindingList<Webshop> webshops = new BindingList<Webshop>();
        public UserControl1()
        {
            InitializeComponent();
            Beolvasás();
            
        }

        private void Beolvasás()
        {

            using (StreamReader sr = new StreamReader("WebshopVégleges.csv", Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');

                    Webshop w = new Webshop();
                    try
                    {
                        w.Rendeles_Id = Convert.ToInt32(sor[0]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }

                    w.Login = sor[1];
                    w.Nev = sor[2];
                    w.email = sor[3];
                    try
                    {
                        w.Szul_Datum = Convert.ToDateTime(sor[4]);
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                        return;
                    }
                    w.Telefon = sor[5];
                    w.Cim = sor[6];
                    try
                    {
                        w.Rend_Ideje = Convert.ToDateTime(sor[7]);
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                        return;
                    }
                    w.Rendelt_Termek = sor[8];
                    try
                    {
                        w.Mennyiseg = Convert.ToInt32(sor[9]);
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                        return;
                    }
                    try
                    {
                        w.egysegar = Convert.ToDecimal(sor[10]);
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }

                    try
                    {
                        w.Összesen = Convert.ToDecimal(sor[11]);

                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message);
                    }

                    webshops.Add(w);


                }
            }

            dataGridView1.DataSource = webshops.ToList();

        }

        private void Ujrendelés_Click(object sender, EventArgs e)
        {
            Újrendelés ú = new Újrendelés();

            if (ú.ShowDialog() == DialogResult.OK)
            {
                Webshop w = new Webshop();
                w.Rendeles_Id = (from x in webshops
                                 select x.Rendeles_Id).Max() + 1;
                w.Login = ú.login.Text;
                w.Nev = ú.nev.Text;
                w.email = ú.email.Text;
                w.Szul_Datum = ú.dateTimePicker1.Value;
                w.Telefon = ú.Telefonszam.Text;
                w.Cim = ú.cim.Text;
                w.Rend_Ideje = ú.dateTimePicker2.Value;
                w.Rendelt_Termek = ú.comboBox1.Text;

                try
                {
                    w.Mennyiseg = Convert.ToInt32(ú.rendmenny.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Rosszul adta meg a rendelt mennyiséget. Kérem egész számot írjon!");
                    return;
                }

                try
                {
                    w.egysegar = Convert.ToDecimal(ú.egysegar.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Rosszul adta meg a rendelt mennyiséget. Kérem valós számot írjon!");
                    return; 
                }

                try
                {
                    w.Összesen = Convert.ToDecimal(ú.egysegar.Text) * Convert.ToDecimal(ú.rendmenny.Text);
                }
                catch (Exception k)
                {

                    MessageBox.Show(k.Message);
                    return;

                }
                webshops.Add(w);
                dataGridView1.DataSource = (from x in webshops select x).ToList();
            }
        }
    }
}
