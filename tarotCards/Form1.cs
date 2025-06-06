using System.Collections;

namespace tarotCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int heart = 3;
        private int[] cardsList;
        private ArrayList selectsCards = new ArrayList();
        private ImageManagement _imageManagement = new ImageManagement();
        private CardsManagement cards = new CardsManagement();

        private void cardRest()
        {
            cardsList = cards.listAdd();
            selectsCards.Clear();

            foreach (Control picture in this.Controls)
            {
                if (picture is PictureBox)
                {
                    _imageManagement.imageAdd((PictureBox)picture, toolTip1, -1);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardRest();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox13, toolTip1, cardsList[0]);
            selectsCards.Add(cardsList[0]);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox12, toolTip1, cardsList[1]);
            selectsCards.Add(cardsList[1]);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox11, toolTip1, cardsList[2]);
            selectsCards.Add(cardsList[2]);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox10, toolTip1, cardsList[3]);
            selectsCards.Add(cardsList[3]);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox9, toolTip1, cardsList[4]);
            selectsCards.Add(cardsList[4]);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox8, toolTip1, cardsList[5]);
            selectsCards.Add(cardsList[5]);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox7, toolTip1, cardsList[6]);
            selectsCards.Add(cardsList[6]);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox6, toolTip1, cardsList[7]);
            selectsCards.Add(cardsList[7]);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox5, toolTip1, cardsList[8]);
            selectsCards.Add(cardsList[8]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox4, toolTip1, cardsList[9]);
            selectsCards.Add(cardsList[9]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox3, toolTip1, cardsList[10]);
            selectsCards.Add(cardsList[10]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox2, toolTip1, cardsList[11]);
            selectsCards.Add(cardsList[11]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox1, toolTip1, cardsList[12]);
            selectsCards.Add(cardsList[12]);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox26, toolTip1, cardsList[13]);
            selectsCards.Add(cardsList[13]);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox25, toolTip1, cardsList[14]);
            selectsCards.Add(cardsList[14]);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox24, toolTip1, cardsList[15]);
            selectsCards.Add(cardsList[15]);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox23, toolTip1, cardsList[16]);
            selectsCards.Add(cardsList[16]);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox22, toolTip1, cardsList[17]);
            selectsCards.Add(cardsList[17]);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox21, toolTip1, cardsList[18]);
            selectsCards.Add(cardsList[18]);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox20, toolTip1, cardsList[19]);
            selectsCards.Add(cardsList[19]);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox19, toolTip1, cardsList[20]);
            selectsCards.Add(cardsList[20]);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox18, toolTip1, cardsList[21]);
            selectsCards.Add(cardsList[21]);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox17, toolTip1, cardsList[22]);
            selectsCards.Add(cardsList[22]);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox16, toolTip1, cardsList[23]);
            selectsCards.Add(cardsList[23]);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox15, toolTip1, cardsList[24]);
            selectsCards.Add(cardsList[24]);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox14, toolTip1, cardsList[25]);
            selectsCards.Add(cardsList[25]);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox39, toolTip1, cardsList[26]);
            selectsCards.Add(cardsList[26]);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox38, toolTip1, cardsList[27]);
            selectsCards.Add(cardsList[27]);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox37, toolTip1, cardsList[28]);
            selectsCards.Add(cardsList[28]);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox36, toolTip1, cardsList[29]);
            selectsCards.Add(cardsList[29]);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox35, toolTip1, cardsList[30]);
            selectsCards.Add(cardsList[30]);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox34, toolTip1, cardsList[31]);
            selectsCards.Add(cardsList[31]);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox33, toolTip1, cardsList[32]);
            selectsCards.Add(cardsList[32]);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox32, toolTip1, cardsList[33]);
            selectsCards.Add(cardsList[33]);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox31, toolTip1, cardsList[34]);
            selectsCards.Add(cardsList[34]);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox30, toolTip1, cardsList[35]);
            selectsCards.Add(cardsList[35]);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox29, toolTip1, cardsList[36]);
            selectsCards.Add(cardsList[36]);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox28, toolTip1, cardsList[37]);
            selectsCards.Add(cardsList[37]);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox27, toolTip1, cardsList[38]);
            selectsCards.Add(cardsList[38]);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox52, toolTip1, cardsList[39]);
            selectsCards.Add(cardsList[39]);
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox51, toolTip1, cardsList[40]);
            selectsCards.Add(cardsList[40]);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox50, toolTip1, cardsList[41]);
            selectsCards.Add(cardsList[41]);
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox49, toolTip1, cardsList[42]);
            selectsCards.Add(cardsList[42]);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox48, toolTip1, cardsList[43]);
            selectsCards.Add(cardsList[43]);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox47, toolTip1, cardsList[44]);
            selectsCards.Add(cardsList[44]);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox46, toolTip1, cardsList[45]);
            selectsCards.Add(cardsList[45]);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox45, toolTip1, cardsList[46]);
            selectsCards.Add(cardsList[46]);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox44, toolTip1, cardsList[47]);
            selectsCards.Add(cardsList[47]);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox43, toolTip1, cardsList[48]);
            selectsCards.Add(cardsList[48]);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox42, toolTip1, cardsList[49]);
            selectsCards.Add(cardsList[49]);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox41, toolTip1, cardsList[50]);
            selectsCards.Add(cardsList[50]);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox40, toolTip1, cardsList[51]);
            selectsCards.Add(cardsList[51]);
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox65, toolTip1, cardsList[52]);
            selectsCards.Add(cardsList[52]);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox64, toolTip1, cardsList[53]);
            selectsCards.Add(cardsList[53]);
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox63, toolTip1, cardsList[54]);
            selectsCards.Add(cardsList[54]);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox62, toolTip1, cardsList[55]);
            selectsCards.Add(cardsList[55]);
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox61, toolTip1, cardsList[56]);
            selectsCards.Add(cardsList[56]);
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox60, toolTip1, cardsList[57]);
            selectsCards.Add(cardsList[57]);
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox59, toolTip1, cardsList[58]);
            selectsCards.Add(cardsList[58]);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox58, toolTip1, cardsList[59]);
            selectsCards.Add(cardsList[59]);
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox57, toolTip1, cardsList[60]);
            selectsCards.Add(cardsList[60]);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox56, toolTip1, cardsList[61]);
            selectsCards.Add(cardsList[61]);
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox55, toolTip1, cardsList[62]);
            selectsCards.Add(cardsList[62]);
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox54, toolTip1, cardsList[63]);
            selectsCards.Add(cardsList[63]);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox53, toolTip1, cardsList[64]);
            selectsCards.Add(cardsList[64]);
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox78, toolTip1, cardsList[65]);
            selectsCards.Add(cardsList[65]);
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox77, toolTip1, cardsList[66]);
            selectsCards.Add(cardsList[66]);
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox76, toolTip1, cardsList[67]);
            selectsCards.Add(cardsList[67]);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox75, toolTip1, cardsList[68]);
            selectsCards.Add(cardsList[68]);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox74, toolTip1, cardsList[69]);
            selectsCards.Add(cardsList[69]);
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox73, toolTip1, cardsList[70]);
            selectsCards.Add(cardsList[70]);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox72, toolTip1, cardsList[71]);
            selectsCards.Add(cardsList[71]);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox71, toolTip1, cardsList[72]);
            selectsCards.Add(cardsList[72]);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox70, toolTip1, cardsList[73]);
            selectsCards.Add(cardsList[73]);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox69, toolTip1, cardsList[74]);
            selectsCards.Add(cardsList[74]);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox68, toolTip1, cardsList[75]);
            selectsCards.Add(cardsList[75]);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox67, toolTip1, cardsList[76]);
            selectsCards.Add(cardsList[76]);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            _imageManagement.imageAdd(pictureBox66, toolTip1, cardsList[77]);
            selectsCards.Add(cardsList[77]);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            cardRest();
            if (heart-- == 0)
            {
                MessageBox.Show("Sa�l���n i�in bu kadar bakmak iyi de�il, o y�zden program kapan�yor", "Fazla Bakt�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama ger�e�i yans�tmamaktad�r, gelecek her zaman de�i�meye mahkumdur yeterki de�i�tirmek iste.", "Uygulama Hakk�nda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportForm from = new ExportForm();
            from.setSelectsCards(selectsCards);
            from.ShowDialog();
        }
        public int red = 255, green = 250, blue = 240;

        void form2_GelenVeri(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            BackcolorSettings backcolorSettings = new BackcolorSettings();
            backcolorSettings.frm1D += new BackcolorSettings.delColor(form2_GelenVeri);
            backcolorSettings.form1SetColor(red, green, blue);
            backcolorSettings.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}