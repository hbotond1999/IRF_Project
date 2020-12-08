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
        WebshopEntities context = new WebshopEntities();
        private List<Webshop> webshops = new List<Webshop>();
        //BindingList<Webshop> webshops = new BindingList<Webshop>();
        public UserControl1()
        {
            InitializeComponent();
           
            dataGridView1.DataSource = (from x in context.Tables
                                       select x).ToList();

            
            
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
                Table t = new Table();
                
                t.Login = ú.login.Text;
                t.Nev = ú.nev.Text;
                t.E_mail = ú.email.Text;
                t.Szuletesi_datum = ú.dateTimePicker1.Value;
                t.Telefon = ú.Telefonszam.Text;
                t.Cim = ú.cim.Text;
                t.Rendeles_ideje = ú.dateTimePicker2.Value;
                 t.Rendelt_termek= ú.comboBox1.Text;
                

                try
                {
                    t.Mennyiseg = Convert.ToInt32(ú.rendmenny.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Rosszul adta meg a rendelt mennyiséget. Kérem egész számot írjon!");
                    return;
                }

                try
                {
                    t.Egysegar = Convert.ToDecimal(ú.egysegar.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Rosszul adta meg a rendelt mennyiséget. Kérem valós számot írjon!");
                    return; 
                }

                try
                {
                    t.Összesen = Convert.ToDecimal(ú.egysegar.Text) * Convert.ToDecimal(ú.rendmenny.Text);
                }
                catch (Exception k)
                {

                    MessageBox.Show(k.Message);
                    return;

                }
                context.Tables.Add(t);
                context.SaveChanges();
                dataGridView1.DataSource = (from x in context.Tables select x).ToList();
            }
        }
    }
}
