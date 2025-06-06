using System;
using System.Collections;
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
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private ArrayList selectsCards;
        private ExportTxt txt = new ExportTxt();

        public void setSelectsCards(ArrayList _selectsCards)
        {
            selectsCards = _selectsCards;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = txt.getFilePath();
            txt.setSelectsCards(selectsCards);
        }

        private void btnSelectFilePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(this);
            txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            txt.setFilePath(folderBrowserDialog1.SelectedPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("İşlemleri çıktı almak istediğinize emin misiniz?", "Çıktı Alım", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                if(txtMe.Text != "")
                {
                    txt.setMe(txtMe.Text);
                }
                if(txtWho.Text != "")
                {
                    txt.setWho(txtWho.Text);
                }
                if(txtWhy.Text != "")
                {
                    txt.setWhy(txtWhy.Text);
                }
                
                txt.writing();

                MessageBox.Show(txt.getFileName() + " isimli dosya " + txt.getFilePath() + " yol uzantısı üzerine başarıyla kaydedildi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
