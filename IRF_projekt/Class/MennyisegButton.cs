using System.Drawing;
using System.Windows.Forms;

namespace IRF_projekt.Class
{
    public class MennyisegButton : Button
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (_value < 0)
                    _value = 10;
                else if (_value > 10)
                    _value = 0;         
               else
                    Text = _value.ToString();

            }
        }


        public MennyisegButton()
        {

            
            BackColor = Color.LightGreen;
            Value = 0;

            MouseDown += MennyisegButton_MouseDown;
        }

        private void MennyisegButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Value++;
            if (e.Button == MouseButtons.Right)
                Value--;
        }
    }
}
