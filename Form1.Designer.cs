namespace práctica_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            RadioCir = new TextBox();
            VolumenCir = new TextBox();
            AreaCir = new TextBox();
            label9 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            AlturaTri = new TextBox();
            label19 = new Label();
            BaseTri = new TextBox();
            label18 = new Label();
            AreaTri = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            label17 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            LadoCub = new TextBox();
            label21 = new Label();
            VolumenCub = new TextBox();
            AreaCub = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label10 = new Label();
            label11 = new Label();
            label3 = new Label();
            tabPage4 = new TabPage();
            AlturaCil = new TextBox();
            label20 = new Label();
            RadioCil = new TextBox();
            label22 = new Label();
            VolumenCil = new TextBox();
            AreaCil = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label12 = new Label();
            label13 = new Label();
            label4 = new Label();
            tabPage5 = new TabPage();
            dmenorRom = new TextBox();
            label23 = new Label();
            DmayorRom = new TextBox();
            label24 = new Label();
            AreaRom = new TextBox();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            label16 = new Label();
            label5 = new Label();
            tabPage6 = new TabPage();
            AristaOct = new TextBox();
            label26 = new Label();
            VolumenOct = new TextBox();
            AreaOct = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label14 = new Label();
            label15 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(-5, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 444);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.RoyalBlue;
            tabPage1.Controls.Add(RadioCir);
            tabPage1.Controls.Add(VolumenCir);
            tabPage1.Controls.Add(AreaCir);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(717, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Circunferencia";
            tabPage1.Click += tabPage1_Click;
            // 
            // RadioCir
            // 
            RadioCir.Location = new Point(151, 141);
            RadioCir.Name = "RadioCir";
            RadioCir.Size = new Size(125, 27);
            RadioCir.TabIndex = 9;
            RadioCir.TextChanged += RadioCir_TextChanged;
            // 
            // VolumenCir
            // 
            VolumenCir.Location = new Point(412, 325);
            VolumenCir.Name = "VolumenCir";
            VolumenCir.Size = new Size(125, 27);
            VolumenCir.TabIndex = 8;
            // 
            // AreaCir
            // 
            AreaCir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AreaCir.Location = new Point(105, 325);
            AreaCir.Name = "AreaCir";
            AreaCir.Size = new Size(125, 27);
            AreaCir.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(61, 138);
            label9.Name = "label9";
            label9.Size = new Size(84, 27);
            label9.TabIndex = 6;
            label9.Text = "Radio:";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(432, 229);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(254, 229);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(76, 229);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(291, 322);
            label8.Name = "label8";
            label8.Size = new Size(115, 27);
            label8.TabIndex = 2;
            label8.Text = "Volumen:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 322);
            label7.Name = "label7";
            label7.Size = new Size(71, 27);
            label7.TabIndex = 1;
            label7.Text = "Área:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 28);
            label1.Name = "label1";
            label1.Size = new Size(264, 39);
            label1.TabIndex = 0;
            label1.Text = "Circunferencia";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Crimson;
            tabPage2.Controls.Add(AlturaTri);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(BaseTri);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(AreaTri);
            tabPage2.Controls.Add(button13);
            tabPage2.Controls.Add(button14);
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(717, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Triángulo";
            // 
            // AlturaTri
            // 
            AlturaTri.Location = new Point(441, 141);
            AlturaTri.Name = "AlturaTri";
            AlturaTri.Size = new Size(125, 27);
            AlturaTri.TabIndex = 18;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(351, 138);
            label19.Name = "label19";
            label19.Size = new Size(88, 27);
            label19.TabIndex = 17;
            label19.Text = "Altura:";
            // 
            // BaseTri
            // 
            BaseTri.Location = new Point(151, 141);
            BaseTri.Name = "BaseTri";
            BaseTri.Size = new Size(125, 27);
            BaseTri.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(61, 138);
            label18.Name = "label18";
            label18.Size = new Size(75, 27);
            label18.TabIndex = 15;
            label18.Text = "Base:";
            // 
            // AreaTri
            // 
            AreaTri.Location = new Point(282, 325);
            AreaTri.Name = "AreaTri";
            AreaTri.Size = new Size(125, 27);
            AreaTri.TabIndex = 14;
            // 
            // button13
            // 
            button13.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(432, 229);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 13;
            button13.Text = "Salir";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(254, 229);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 12;
            button14.Text = "Borrar";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(76, 229);
            button15.Name = "button15";
            button15.Size = new Size(107, 29);
            button15.TabIndex = 11;
            button15.Text = "Calcular";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(205, 322);
            label17.Name = "label17";
            label17.Size = new Size(71, 27);
            label17.TabIndex = 9;
            label17.Text = "Área:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 28);
            label2.Name = "label2";
            label2.Size = new Size(175, 39);
            label2.TabIndex = 1;
            label2.Text = "Triángulo";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Wheat;
            tabPage3.Controls.Add(LadoCub);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(VolumenCub);
            tabPage3.Controls.Add(AreaCub);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(717, 411);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cubo";
            // 
            // LadoCub
            // 
            LadoCub.Location = new Point(151, 141);
            LadoCub.Name = "LadoCub";
            LadoCub.Size = new Size(125, 27);
            LadoCub.TabIndex = 20;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(61, 138);
            label21.Name = "label21";
            label21.Size = new Size(74, 27);
            label21.TabIndex = 19;
            label21.Text = "Lado:";
            // 
            // VolumenCub
            // 
            VolumenCub.Location = new Point(412, 325);
            VolumenCub.Name = "VolumenCub";
            VolumenCub.Size = new Size(125, 27);
            VolumenCub.TabIndex = 15;
            // 
            // AreaCub
            // 
            AreaCub.Location = new Point(105, 325);
            AreaCub.Name = "AreaCub";
            AreaCub.Size = new Size(125, 27);
            AreaCub.TabIndex = 14;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(432, 229);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(254, 229);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(76, 229);
            button6.Name = "button6";
            button6.Size = new Size(107, 29);
            button6.TabIndex = 11;
            button6.Text = "Calcular";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(291, 322);
            label10.Name = "label10";
            label10.Size = new Size(115, 27);
            label10.TabIndex = 10;
            label10.Text = "Volumen:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 322);
            label11.Name = "label11";
            label11.Size = new Size(71, 27);
            label11.TabIndex = 9;
            label11.Text = "Área:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(230, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 39);
            label3.TabIndex = 2;
            label3.Text = "Cubo";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.PaleGreen;
            tabPage4.Controls.Add(AlturaCil);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(RadioCil);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(VolumenCil);
            tabPage4.Controls.Add(AreaCil);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(717, 411);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cilindro";
            // 
            // AlturaCil
            // 
            AlturaCil.Location = new Point(441, 141);
            AlturaCil.Name = "AlturaCil";
            AlturaCil.Size = new Size(125, 27);
            AlturaCil.TabIndex = 22;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(351, 138);
            label20.Name = "label20";
            label20.Size = new Size(88, 27);
            label20.TabIndex = 21;
            label20.Text = "Altura:";
            // 
            // RadioCil
            // 
            RadioCil.Location = new Point(151, 141);
            RadioCil.Name = "RadioCil";
            RadioCil.Size = new Size(125, 27);
            RadioCil.TabIndex = 20;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(61, 138);
            label22.Name = "label22";
            label22.Size = new Size(84, 27);
            label22.TabIndex = 19;
            label22.Text = "Radio:";
            // 
            // VolumenCil
            // 
            VolumenCil.Location = new Point(412, 325);
            VolumenCil.Name = "VolumenCil";
            VolumenCil.Size = new Size(125, 27);
            VolumenCil.TabIndex = 15;
            // 
            // AreaCil
            // 
            AreaCil.Location = new Point(105, 325);
            AreaCil.Name = "AreaCil";
            AreaCil.Size = new Size(125, 27);
            AreaCil.TabIndex = 14;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(432, 229);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 13;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(254, 229);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 12;
            button8.Text = "Borrar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(76, 229);
            button9.Name = "button9";
            button9.Size = new Size(107, 29);
            button9.TabIndex = 11;
            button9.Text = "Calcular";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(291, 322);
            label12.Name = "label12";
            label12.Size = new Size(115, 27);
            label12.TabIndex = 10;
            label12.Text = "Volumen:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(28, 322);
            label13.Name = "label13";
            label13.Size = new Size(71, 27);
            label13.TabIndex = 9;
            label13.Text = "Área:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(232, 28);
            label4.Name = "label4";
            label4.Size = new Size(147, 39);
            label4.TabIndex = 1;
            label4.Text = "Cilindro";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Turquoise;
            tabPage5.Controls.Add(dmenorRom);
            tabPage5.Controls.Add(label23);
            tabPage5.Controls.Add(DmayorRom);
            tabPage5.Controls.Add(label24);
            tabPage5.Controls.Add(AreaRom);
            tabPage5.Controls.Add(button16);
            tabPage5.Controls.Add(button17);
            tabPage5.Controls.Add(button18);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(717, 411);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Rombo";
            // 
            // dmenorRom
            // 
            dmenorRom.Location = new Point(349, 169);
            dmenorRom.Name = "dmenorRom";
            dmenorRom.Size = new Size(125, 27);
            dmenorRom.TabIndex = 23;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(152, 166);
            label23.Name = "label23";
            label23.Size = new Size(195, 27);
            label23.TabIndex = 22;
            label23.Text = "Diagonal menor:";
            // 
            // DmayorRom
            // 
            DmayorRom.Location = new Point(349, 110);
            DmayorRom.Name = "DmayorRom";
            DmayorRom.Size = new Size(125, 27);
            DmayorRom.TabIndex = 21;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(152, 110);
            label24.Name = "label24";
            label24.Size = new Size(191, 27);
            label24.TabIndex = 20;
            label24.Text = "Diagonal mayor:";
            // 
            // AreaRom
            // 
            AreaRom.Location = new Point(282, 325);
            AreaRom.Name = "AreaRom";
            AreaRom.Size = new Size(125, 27);
            AreaRom.TabIndex = 19;
            // 
            // button16
            // 
            button16.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(432, 229);
            button16.Name = "button16";
            button16.Size = new Size(94, 29);
            button16.TabIndex = 18;
            button16.Text = "Salir";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(254, 229);
            button17.Name = "button17";
            button17.Size = new Size(94, 29);
            button17.TabIndex = 17;
            button17.Text = "Borrar";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(76, 229);
            button18.Name = "button18";
            button18.Size = new Size(107, 29);
            button18.TabIndex = 16;
            button18.Text = "Calcular";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(205, 322);
            label16.Name = "label16";
            label16.Size = new Size(71, 27);
            label16.TabIndex = 15;
            label16.Text = "Área:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(235, 28);
            label5.Name = "label5";
            label5.Size = new Size(134, 39);
            label5.TabIndex = 1;
            label5.Text = "Rombo";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.LemonChiffon;
            tabPage6.Controls.Add(AristaOct);
            tabPage6.Controls.Add(label26);
            tabPage6.Controls.Add(VolumenOct);
            tabPage6.Controls.Add(AreaOct);
            tabPage6.Controls.Add(button10);
            tabPage6.Controls.Add(button11);
            tabPage6.Controls.Add(button12);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(label15);
            tabPage6.Controls.Add(label6);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(717, 411);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Octaedro";
            // 
            // AristaOct
            // 
            AristaOct.Location = new Point(151, 141);
            AristaOct.Name = "AristaOct";
            AristaOct.Size = new Size(125, 27);
            AristaOct.TabIndex = 20;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(61, 138);
            label26.Name = "label26";
            label26.Size = new Size(86, 27);
            label26.TabIndex = 19;
            label26.Text = "Arista:";
            // 
            // VolumenOct
            // 
            VolumenOct.Location = new Point(412, 325);
            VolumenOct.Name = "VolumenOct";
            VolumenOct.Size = new Size(125, 27);
            VolumenOct.TabIndex = 15;
            // 
            // AreaOct
            // 
            AreaOct.Location = new Point(105, 325);
            AreaOct.Name = "AreaOct";
            AreaOct.Size = new Size(125, 27);
            AreaOct.TabIndex = 14;
            // 
            // button10
            // 
            button10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(432, 229);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 13;
            button10.Text = "Salir";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(254, 229);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 12;
            button11.Text = "Borrar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(76, 229);
            button12.Name = "button12";
            button12.Size = new Size(107, 29);
            button12.TabIndex = 11;
            button12.Text = "Calcular";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(291, 322);
            label14.Name = "label14";
            label14.Size = new Size(115, 27);
            label14.TabIndex = 10;
            label14.Text = "Volumen:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(28, 322);
            label15.Name = "label15";
            label15.Size = new Size(71, 27);
            label15.TabIndex = 9;
            label15.Text = "Área:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(215, 28);
            label6.Name = "label6";
            label6.Size = new Size(173, 39);
            label6.TabIndex = 1;
            label6.Text = "Octaedro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Calcular el área de una figura geométrica";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label7;
        private TextBox VolumenCir;
        private TextBox AreaCir;
        private TextBox VolumenCub;
        private TextBox AreaCub;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label10;
        private Label label11;
        private TextBox VolumenCil;
        private TextBox AreaCil;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label12;
        private Label label13;
        private TextBox VolumenOct;
        private TextBox AreaOct;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label14;
        private Label label15;
        private TextBox AreaTri;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label17;
        private TextBox AreaRom;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label16;
        private TextBox RadioCir;
        private TextBox AlturaTri;
        private Label label19;
        private TextBox BaseTri;
        private Label label18;
        private TextBox LadoCub;
        private Label label21;
        private TextBox AlturaCil;
        private Label label20;
        private TextBox RadioCil;
        private Label label22;
        private TextBox DmayorRom;
        private Label label24;
        private TextBox AristaOct;
        private Label label26;
        private TextBox dmenorRom;
        private Label label23;
    }
}