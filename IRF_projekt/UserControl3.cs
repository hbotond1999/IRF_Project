using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class UserControl3 : UserControl
    {
        WebshopEntities context = new WebshopEntities();
        private List<Webshop> webshops = new List<Webshop>();
        public UserControl3()
        {
            InitializeComponent();
            
            
        }

        private void Beolvasás()
        {

            using (StreamReader sr = new StreamReader(textBox1.Text, Encoding.UTF8))
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

        private void Button1_Click(object sender, EventArgs e)
        {

            /*Table table = new Table();
            try
            {
                table.Login = Convert.ToString(webshops[1]);
            }
            catch (Exception)
            {

                MessageBox.Show("Login hiba");
                return;
            }

            try
            {
                table.Nev = Convert.ToString(webshops[2]);
            }
            catch (Exception)
            {

                MessageBox.Show("Nev hiba");
                return;
            }
            try
            {
                table.E_mail = Convert.ToString(webshops[3]);
            }
            catch (Exception)
            {

                MessageBox.Show("E-mail hiba");
                return;
            }

            try
            {
                table.Szuletesi_datum =Convert.ToDateTime(webshops[4]);
            }
            catch (Exception)
            {

                MessageBox.Show("Szuletési datum hiba");
                return;
            }
            try
            {
                table.Telefon = Convert.ToString(webshops[5]);
            }
            catch (Exception)
            {

                MessageBox.Show("Telefon hiba");
                return;
            }

            try
            {
                table.Cim = Convert.ToString(webshops[6]);
            }
            catch (Exception)
            {

                MessageBox.Show("Cim hiba");
                return;
            }

            try
            {
                table.Rendeles_ideje = Convert.ToDateTime(webshops[7]);
            }
            catch (Exception)
            {

                MessageBox.Show("Rendelés ideje hiba");
                return;
            }

            try
            {
                table.Rendelt_termek = Convert.ToString(webshops[8]);
            }
            catch (Exception)
            {

                MessageBox.Show("Rendelt termek hiba");
                return;
            }

            try
            {
                table.Mennyiseg = Convert.ToInt32(webshops[9]);
            }
            catch (Exception)
            {

                MessageBox.Show("Mennyiseg hiba");
                return;
            }

            try
            {
                table.Egysegar = Convert.ToDecimal(webshops[10]);
            }
            catch (Exception)
            {

                MessageBox.Show("Egyseg ar hiba");
                return;
            }

            try
            {
                table.Összesen = Convert.ToDecimal(webshops[11]);
            }
            catch (Exception)
            {

                MessageBox.Show("Összesen hiba");
                return;
            }
            

            context.Tables.Add(table);

            try
            {
                context.SaveChanges();
            }
            catch (Exception c)
            {

                MessageBox.Show(c.Message);
            }
            */

            using (StreamReader sr = new StreamReader(textBox1.Text, Encoding.UTF8))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');

                    Table t = new Table();
                   

                    t.Login = sor[1];
                    t.Nev = sor[2];
                    t.E_mail = sor[3];
                    try
                    {
                        t.Szuletesi_datum = Convert.ToDateTime(sor[4]);
                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.Message);
                        return;
                    }
                    t.Telefon = sor[5];
                    t.Cim = sor[6];
                    try
                    {
                        t.Rendeles_ideje = Convert.ToDateTime(sor[7]);
                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.Message);
                        return;
                    }
                    t.Rendelt_termek = sor[8];
                    try
                    {
                        t.Mennyiseg = Convert.ToInt32(sor[9]);
                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.Message);
                        return;
                    }
                    try
                    {
                        t.Egysegar = Convert.ToDecimal(sor[10]);
                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.Message);
                    }

                    try
                    {
                        t.Összesen = Convert.ToDecimal(sor[11]);

                    }
                    catch (Exception x)
                    {

                        MessageBox.Show(x.Message);
                    }

                    context.Tables.Add(t);
                    context.SaveChanges();

                    

                }
            }

            MessageBox.Show("Sikeres mentés");

           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                 Beolvasás();
            }
            catch (Exception)
            {
                MessageBox.Show("Kérem jó fájlt adjon meg (a projektben található a WebshopVégleges.csv)");
            }
            

        }
    }
}
