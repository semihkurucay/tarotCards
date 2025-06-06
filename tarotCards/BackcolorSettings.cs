using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarotCards
{
    public partial class BackcolorSettings : Form
    {
        public BackcolorSettings()
        {
            InitializeComponent();
        }

        public int red, green, blue;

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            trcRed.Value = Convert.ToInt32(nudRed.Value);
            colors();
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            trcGreen.Value = Convert.ToInt32(nudGreen.Value);
            colors();
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            trcBlue.Value = Convert.ToInt32(nudBlue.Value);
            colors();
        }

        private void trcRed_Scroll(object sender, EventArgs e)
        {
            nudRed.Value = trcRed.Value;
            colors();
        }

        private void trcGreen_Scroll(object sender, EventArgs e)
        {
            nudGreen.Value = trcGreen.Value;
            colors();
        }

        private void trcBlue_Scroll(object sender, EventArgs e)
        {
            nudBlue.Value = trcBlue.Value;
            colors();
        }

        private void selectColor()
        {
            red = Convert.ToInt32(nudRed.Value);
            green = Convert.ToInt32(nudGreen.Value);
            blue = Convert.ToInt32(nudBlue.Value);
        }

        private void setColor()
        {
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        public void form1SetColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        private void colors()
        {
            selectColor();
            setColor();
            this.frm1D(red, green, blue);
        }

        private void BackcolorSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(red, green, blue);

            int _red = red, _green = green, _blue = blue;

            nudRed.Value = _red;
            nudGreen.Value = _green;
            nudBlue.Value = _blue;

            trcRed.Value = _red;
            trcGreen.Value = _green;
            trcBlue.Value = _blue;
        }

        private void BackcolorSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Arka plan rengi uygulanması için sayfayı \"YENİLE\" yapın.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackcolorSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public delegate void delColor(int red, int green, int blue);
        public event delColor frm1D;
    }
}
