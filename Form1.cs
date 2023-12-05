using System;
using System.Drawing;

namespace práctica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(RadioCir.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            AreaCir.Text = area1.ToString("0.##");
            VolumenCir.Text = volumen1.ToString("0.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RadioCir.Clear();
            AreaCir.Clear();
            VolumenCir.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double base2, altura2, area2;
            base2 = double.Parse(BaseTri.Text);
            altura2 = double.Parse(AlturaTri.Text);
            area2 = base2 * altura2 / 2;
            AreaTri.Text = area2.ToString("0.##");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BaseTri.Clear();
            AlturaTri.Clear();
            AreaTri.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double lado3, area3, volumen3;
            lado3 = double.Parse(LadoCub.Text);
            area3 = 6 * lado3 * lado3;
            volumen3 = Math.Pow(lado3, 3);
            AreaCub.Text = area3.ToString("0.##");
            VolumenCub.Text = volumen3.ToString("0.##");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LadoCub.Clear();
            AreaCub.Clear();
            VolumenCub.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio4, altura4, area4, volumen4;
            radio4 = double.Parse(RadioCil.Text);
            altura4 = double.Parse(AlturaCil.Text);
            area4 = 2 * pi * radio4 * altura4 + 2 * pi * radio4 * radio4;
            volumen4 = pi * radio4 * radio4 * altura4;

            RadioCil.Text = radio4.ToString("0.##");
            AlturaCil.Text = altura4.ToString("0.##");
            AreaCil.Text = area4.ToString("0.##");
            VolumenCil.Text = volumen4.ToString("0.##");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RadioCil.Clear();
            AlturaCil.Clear();
            AreaCil.Clear();
            VolumenCil.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double Dmayor5, dmenor5, area5;
            Dmayor5 = double.Parse(DmayorRom.Text);
            dmenor5 = double.Parse(dmenorRom.Text);
            area5 = Dmayor5 * dmenor5 / 2;

            AreaRom.Text = area5.ToString("0.##");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DmayorRom.Clear();
            dmenorRom.Clear();
            AreaRom.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double arista6, area6, volumen6;
            arista6 = double.Parse(AristaOct.Text);
            area6 = 2 * Math.Sqrt(3) * arista6 * arista6;
            volumen6 = Math.Sqrt(2) / 3 * Math.Pow(arista6, 3);

            AreaOct.Text = area6.ToString("0.##");
            VolumenOct.Text = volumen6.ToString("0.##");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AristaOct.Clear();
            AreaOct.Clear();
            VolumenOct.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RadioCir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}