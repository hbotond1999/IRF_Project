using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class UserControl5 : UserControl
    {
        WebshopEntities context = new WebshopEntities();
        public UserControl5()
        {
            InitializeComponent();
            Bevetel();
        }

        private void Bevetel()
        {
            var er = from x in context.Tables
                     group x by new { x.Rendelt_termek } into g
                     select new
                     {
                         Termeknev = g.Key.Rendelt_termek,

                         Mennyiseg = (from x in g select x.Mennyiseg).Sum(),
                         Bevetel = (from x in g select x.Egysegar*x.Mennyiseg).Sum()

                     };

            bevételBindingSource.DataSource = er.ToList();
            chart1.DataBind();

            label2.Text = ((from x in er select x.Bevetel).Sum()).ToString() + " Ft";
        }
    }
}
