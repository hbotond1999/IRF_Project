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

            Height = 30;
            Width = 30;
            BackColor = Color.LightGreen;
            Value = 0;

            MouseDown += KedvezmenyButton_MouseDown;
        }

        private void KedvezmenyButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Value++;
            if (e.Button == MouseButtons.Right)
                Value--;
        }
    }
}
