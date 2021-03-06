﻿using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IRF_projekt
{
    public partial class UserControl4 : UserControl
    {
        WebshopEntities context = new WebshopEntities();
        public UserControl4()
        {
            InitializeComponent();
            termekek();

        }

        private void termekek()
        {
            var er = from x in context.Tables
                     group x by new { x.Rendelt_termek } into g
                     select new
                     {
                         Termeknev = g.Key.Rendelt_termek,

                         Darab = (from x in g select x.Mennyiseg).Sum()

                     };

            eladottmennyisegBindingSource.DataSource = er.ToList();
            chart1.DataBind();

            label2.Text = ((from x in er
                           select x.Darab).Sum()).ToString();
        }
    }
}
