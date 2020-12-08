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
       
        //BindingList<Webshop> webshops = new BindingList<Webshop>();
        public UserControl1()
        {
            InitializeComponent();
           
            dataGridView1.DataSource = (from x in context.Tables
                                       select x).ToList();

            
            
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
