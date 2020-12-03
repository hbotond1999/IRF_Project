using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_projekt.Class;

namespace IRF_projekt
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            Karácsonyfa();

        }

        private void Karácsonyfa()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Karácsonyfa k = new Karácsonyfa();
                    k.Left=50*j+ Width / 2 - i * 50 / 2;
                    k.Top = 50 * i;
                    Controls.Add(k);
                    
                }
               
            }

            Fatörzs f = new Fatörzs();
            f.Left= 50 *1  + Width / 2 -  1* 50 /2;
            f.Top = 50 * 8;
            Controls.Add(f);
            Fatörzs f1 = new Fatörzs();
            f1.Left = 50 * -1 + Width / 2 - -1 * 50 / 2;
            f1.Top= 50 * 8;
            Controls.Add(f1);

        }
    }
}
