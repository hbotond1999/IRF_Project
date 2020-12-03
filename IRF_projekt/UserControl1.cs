using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class UserControl1 : UserControl
    {
        private List<Webshop> webshops = new List<Webshop>();
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
                    catch (Exception)
                    {
                        MessageBox.Show("Rendeles_Id beolvasása nem sikerült");
                        return;
                    }

                    w.Login = sor[1];
                    w.Nev = sor[2];
                    w.email = sor[3];
                    try
                    {
                        w.Szul_Datum = Convert.ToDateTime(sor[4]);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Szul_Datum beolvasása nem sikerült");
                        return;
                    }
                    w.Telefon = sor[5];
                    w.Cim = sor[6];
                    try
                    {
                        w.Rend_Ideje = Convert.ToDateTime(sor[7]);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Rend_Ideje beolvasása nem sikerült");
                        return;
                    }
                    w.Rendelt_Termek = sor[8];
                    try
                    {
                        w.Mennyiseg = Convert.ToInt32(sor[9]);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mennyiseg beolvasása nem sikerült");
                        return;
                    }

                    webshops.Add(w);


                }
            }

            dataGridView1.DataSource = webshops.ToList();

        }
    }
}
