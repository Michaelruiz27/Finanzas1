namespace Finanzas
{
    partial class Endeudamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endeudamiento));
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            btnRealizarOperacion = new Button();
            lblCargosPorIntereses = new Label();
            label2 = new Label();
            label25 = new Label();
            lblUtilidadAntesintereses = new Label();
            label3 = new Label();
            label20 = new Label();
            lblRotacionInteresesutilidad = new Label();
            label21 = new Label();
            label18 = new Label();
            groupBox2 = new GroupBox();
            lblRazonPaivoCaptal = new Label();
            label15 = new Label();
            lblInventario = new Label();
            lblCapitalSocial = new Label();
            label17 = new Label();
            lblPasivosLP = new Label();
            label14 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            lblrazondeudatotal = new Label();
            label11 = new Label();
            lblacttotales = new Label();
            label9 = new Label();
            lblpastotales = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label23 = new Label();
            label24 = new Label();
            label16 = new Label();
            label19 = new Label();
            label22 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 67);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(255, 19);
            label1.Name = "label1";
            label1.Size = new Size(656, 45);
            label1.TabIndex = 8;
            label1.Text = "RAZONES DE ENDEUDAMIENTO";
            // 
            // btnAtras
            // 
            btnAtras.Image = (Image)resources.GetObject("btnAtras.Image");
            btnAtras.Location = new Point(0, 0);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(64, 64);
            btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAtras.TabIndex = 5;
            btnAtras.TabStop = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 697);
            panel2.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRealizarOperacion);
            groupBox3.Controls.Add(lblCargosPorIntereses);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lblUtilidadAntesintereses);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(lblRotacionInteresesutilidad);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label19);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox3.Location = new Point(18, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1131, 313);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rotacion de intereses a utilidad";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnRealizarOperacion
            // 
            btnRealizarOperacion.BackColor = Color.LimeGreen;
            btnRealizarOperacion.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnRealizarOperacion.ForeColor = Color.Black;
            btnRealizarOperacion.Location = new Point(867, 229);
            btnRealizarOperacion.Name = "btnRealizarOperacion";
            btnRealizarOperacion.Size = new Size(243, 52);
            btnRealizarOperacion.TabIndex = 11;
            btnRealizarOperacion.Text = "Realizar Operaciones";
            btnRealizarOperacion.UseVisualStyleBackColor = false;
            btnRealizarOperacion.Click += btnRealizarOperacion_Click;
            // 
            // lblCargosPorIntereses
            // 
            lblCargosPorIntereses.Anchor = AnchorStyles.Top;
            lblCargosPorIntereses.AutoSize = true;
            lblCargosPorIntereses.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblCargosPorIntereses.ForeColor = Color.FromArgb(35, 55, 80);
            lblCargosPorIntereses.Location = new Point(659, 229);
            lblCargosPorIntereses.Name = "lblCargosPorIntereses";
            lblCargosPorIntereses.Size = new Size(54, 25);
            lblCargosPorIntereses.TabIndex = 31;
            lblCargosPorIntereses.Text = "0.00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(35, 55, 80);
            label2.Location = new Point(541, 100);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 23;
            label2.Text = "𝒄𝒂𝒓𝒈𝒐𝒔 𝒑𝒐𝒓 𝒊𝒏𝒕𝒆𝒓𝒆𝒔𝒆𝒔";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.AutoSize = true;
            label25.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label25.ForeColor = Color.FromArgb(35, 55, 80);
            label25.Location = new Point(435, 188);
            label25.Name = "label25";
            label25.Size = new Size(528, 25);
            label25.TabIndex = 30;
            label25.Text = "___________________________________________";
            // 
            // lblUtilidadAntesintereses
            // 
            lblUtilidadAntesintereses.Anchor = AnchorStyles.Top;
            lblUtilidadAntesintereses.AutoSize = true;
            lblUtilidadAntesintereses.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblUtilidadAntesintereses.ForeColor = Color.FromArgb(35, 55, 80);
            lblUtilidadAntesintereses.Location = new Point(659, 179);
            lblUtilidadAntesintereses.Name = "lblUtilidadAntesintereses";
            lblUtilidadAntesintereses.Size = new Size(54, 25);
            lblUtilidadAntesintereses.TabIndex = 29;
            lblUtilidadAntesintereses.Text = "0.00";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(35, 55, 80);
            label3.Location = new Point(456, 68);
            label3.Name = "label3";
            label3.Size = new Size(528, 25);
            label3.TabIndex = 22;
            label3.Text = "___________________________________________";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(35, 55, 80);
            label20.Location = new Point(506, 57);
            label20.Name = "label20";
            label20.Size = new Size(387, 25);
            label20.TabIndex = 21;
            label20.Text = "𝒖𝒕𝒊𝒍𝒊𝒅𝒂𝒅 𝒂𝒏𝒕𝒆𝒔 𝒅𝒆 𝒊𝒏𝒕𝒆𝒓𝒆𝒔𝒆𝒔 𝒆 𝒊𝒎𝒑𝒖𝒆𝒔𝒕𝒐𝒔";
            // 
            // lblRotacionInteresesutilidad
            // 
            lblRotacionInteresesutilidad.Anchor = AnchorStyles.Top;
            lblRotacionInteresesutilidad.AutoSize = true;
            lblRotacionInteresesutilidad.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblRotacionInteresesutilidad.ForeColor = Color.FromArgb(219, 147, 10);
            lblRotacionInteresesutilidad.Location = new Point(280, 243);
            lblRotacionInteresesutilidad.Name = "lblRotacionInteresesutilidad";
            lblRotacionInteresesutilidad.Size = new Size(54, 25);
            lblRotacionInteresesutilidad.TabIndex = 16;
            lblRotacionInteresesutilidad.Text = "0.00";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(35, 55, 80);
            label21.Location = new Point(187, 241);
            label21.Name = "label21";
            label21.Size = new Size(70, 25);
            label21.TabIndex = 12;
            label21.Text = "Total:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(35, 55, 80);
            label18.Location = new Point(1, 73);
            label18.Name = "label18";
            label18.Size = new Size(437, 25);
            label18.TabIndex = 10;
            label18.Text = "𝑹𝒂𝒛ó𝒏  𝒅𝒆 𝒍𝒂 𝒄𝒂𝒑𝒂𝒄𝒊𝒅𝒂𝒅 𝒅𝒆 𝒑𝒂𝒈𝒐 𝒅𝒆 𝒊𝒏𝒕𝒆𝒓𝒆𝒔 =";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(lblRazonPaivoCaptal);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(lblInventario);
            groupBox2.Controls.Add(lblCapitalSocial);
            groupBox2.Controls.Add(lblPasivosLP);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label17);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox2.Location = new Point(578, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 328);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Razon pasivo Capital";
            // 
            // lblRazonPaivoCaptal
            // 
            lblRazonPaivoCaptal.Anchor = AnchorStyles.Top;
            lblRazonPaivoCaptal.AutoSize = true;
            lblRazonPaivoCaptal.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblRazonPaivoCaptal.ForeColor = Color.FromArgb(215, 143, 35);
            lblRazonPaivoCaptal.Location = new Point(125, 277);
            lblRazonPaivoCaptal.Name = "lblRazonPaivoCaptal";
            lblRazonPaivoCaptal.Size = new Size(54, 25);
            lblRazonPaivoCaptal.TabIndex = 28;
            lblRazonPaivoCaptal.Text = "0.00";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(35, 55, 80);
            label15.Location = new Point(17, 275);
            label15.Name = "label15";
            label15.Size = new Size(70, 25);
            label15.TabIndex = 27;
            label15.Text = "Total:";
            // 
            // lblInventario
            // 
            lblInventario.Anchor = AnchorStyles.Top;
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Bookman Old Style", 12F);
            lblInventario.ForeColor = Color.FromArgb(35, 55, 80);
            lblInventario.Location = new Point(589, 149);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(52, 23);
            lblInventario.TabIndex = 25;
            lblInventario.Text = "0.00";
            // 
            // lblCapitalSocial
            // 
            lblCapitalSocial.Anchor = AnchorStyles.Top;
            lblCapitalSocial.AutoSize = true;
            lblCapitalSocial.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblCapitalSocial.ForeColor = Color.FromArgb(35, 55, 80);
            lblCapitalSocial.Location = new Point(262, 211);
            lblCapitalSocial.Name = "lblCapitalSocial";
            lblCapitalSocial.Size = new Size(54, 25);
            lblCapitalSocial.TabIndex = 24;
            lblCapitalSocial.Text = "0.00";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(35, 55, 80);
            label17.Location = new Point(107, 179);
            label17.Name = "label17";
            label17.Size = new Size(528, 25);
            label17.TabIndex = 23;
            label17.Text = "___________________________________________";
            // 
            // lblPasivosLP
            // 
            lblPasivosLP.Anchor = AnchorStyles.Top;
            lblPasivosLP.AutoSize = true;
            lblPasivosLP.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblPasivosLP.ForeColor = Color.FromArgb(35, 55, 80);
            lblPasivosLP.Location = new Point(262, 168);
            lblPasivosLP.Name = "lblPasivosLP";
            lblPasivosLP.Size = new Size(54, 25);
            lblPasivosLP.TabIndex = 22;
            lblPasivosLP.Text = "0.00";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F);
            label14.ForeColor = Color.FromArgb(35, 55, 80);
            label14.Location = new Point(568, 39);
            label14.Name = "label14";
            label14.Size = new Size(112, 23);
            label14.TabIndex = 21;
            label14.Text = "Inventario";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(35, 55, 80);
            label10.Location = new Point(233, 101);
            label10.Name = "label10";
            label10.Size = new Size(145, 25);
            label10.TabIndex = 20;
            label10.Text = "𝑪𝒂𝒑𝒊𝒕𝒂𝒍 𝒔𝒐𝒄𝒊𝒂𝒍";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(35, 55, 80);
            label12.Location = new Point(99, 69);
            label12.Name = "label12";
            label12.Size = new Size(528, 25);
            label12.TabIndex = 19;
            label12.Text = "___________________________________________";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(35, 55, 80);
            label13.Location = new Point(233, 59);
            label13.Name = "label13";
            label13.Size = new Size(130, 25);
            label13.TabIndex = 18;
            label13.Text = "𝑷𝒂𝒔𝒊𝒗𝒐 𝒂 𝑳/𝑷";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(35, 55, 80);
            label8.Location = new Point(17, 68);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 17;
            label8.Text = "R.P.C =";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblrazondeudatotal);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblacttotales);
            groupBox1.Controls.Add(lblpastotales);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox1.Location = new Point(19, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 328);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Razon de deuda total";
            // 
            // lblrazondeudatotal
            // 
            lblrazondeudatotal.Anchor = AnchorStyles.Top;
            lblrazondeudatotal.AutoSize = true;
            lblrazondeudatotal.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblrazondeudatotal.ForeColor = Color.FromArgb(215, 143, 35);
            lblrazondeudatotal.Location = new Point(190, 266);
            lblrazondeudatotal.Name = "lblrazondeudatotal";
            lblrazondeudatotal.Size = new Size(54, 25);
            lblrazondeudatotal.TabIndex = 18;
            lblrazondeudatotal.Text = "0.00";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(35, 55, 80);
            label11.Location = new Point(94, 264);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 16;
            label11.Text = "Total:";
            // 
            // lblacttotales
            // 
            lblacttotales.Anchor = AnchorStyles.Top;
            lblacttotales.AutoSize = true;
            lblacttotales.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblacttotales.ForeColor = Color.FromArgb(35, 55, 80);
            lblacttotales.Location = new Point(306, 211);
            lblacttotales.Name = "lblacttotales";
            lblacttotales.Size = new Size(54, 25);
            lblacttotales.TabIndex = 15;
            lblacttotales.Text = "0.00";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(35, 55, 80);
            label9.Location = new Point(211, 179);
            label9.Name = "label9";
            label9.Size = new Size(336, 25);
            label9.TabIndex = 14;
            label9.Text = "___________________________";
            // 
            // lblpastotales
            // 
            lblpastotales.Anchor = AnchorStyles.Top;
            lblpastotales.AutoSize = true;
            lblpastotales.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            lblpastotales.ForeColor = Color.FromArgb(35, 55, 80);
            lblpastotales.Location = new Point(306, 168);
            lblpastotales.Name = "lblpastotales";
            lblpastotales.Size = new Size(54, 25);
            lblpastotales.TabIndex = 13;
            lblpastotales.Text = "0.00";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(35, 55, 80);
            label7.Location = new Point(254, 101);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 12;
            label7.Text = "𝐀𝐜𝐭𝐢𝐯𝐨𝐬 𝐭𝐨𝐭𝐚𝐥𝐞𝐬";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(211, 68);
            label6.Name = "label6";
            label6.Size = new Size(336, 25);
            label6.TabIndex = 11;
            label6.Text = "___________________________";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(254, 59);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 10;
            label5.Text = "𝐏𝐚𝐬𝐢𝐯𝐨𝐬 𝐭𝐨𝐭𝐚𝐥𝐞𝐬";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(16, 59);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 9;
            label4.Text = "R.D.D =";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Bookman Old Style", 10.2F);
            label23.ForeColor = Color.FromArgb(35, 55, 80);
            label23.Location = new Point(385, 613);
            label23.Name = "label23";
            label23.Size = new Size(397, 21);
            label23.TabIndex = 30;
            label23.Text = "___________________________________________";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Bookman Old Style", 12F);
            label24.ForeColor = Color.FromArgb(35, 55, 80);
            label24.Location = new Point(539, 589);
            label24.Name = "label24";
            label24.Size = new Size(52, 23);
            label24.TabIndex = 29;
            label24.Text = "0.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(107, 277);
            label16.Name = "label16";
            label16.Size = new Size(25, 23);
            label16.TabIndex = 29;
            label16.Text = "$ ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(263, 243);
            label19.Name = "label19";
            label19.Size = new Size(25, 23);
            label19.TabIndex = 30;
            label19.Text = "$ ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(170, 266);
            label22.Name = "label22";
            label22.Size = new Size(25, 23);
            label22.TabIndex = 31;
            label22.Text = "$ ";
            // 
            // Endeudamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 733);
            Controls.Add(panel2);
            Controls.Add(label23);
            Controls.Add(panel1);
            Controls.Add(label24);
            Name = "Endeudamiento";
            Text = "Endeudamiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnAtras;
        private Panel panel2;
        private Button btnRealizarOperacion;
        private GroupBox groupBox3;
        private Label lblRotacionInteresesutilidad;
        private Label label21;
        private Label label18;
        private GroupBox groupBox2;
        private Label lblRazonPaivoCaptal;
        private Label label15;
        private Label lblInventario;
        private Label lblCapitalSocial;
        private Label label17;
        private Label lblPasivosLP;
        private Label label14;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label8;
        private GroupBox groupBox1;
        private Label lblrazondeudatotal;
        private Label label11;
        private Label lblacttotales;
        private Label label9;
        private Label lblpastotales;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label20;
        private Label lblCargosPorIntereses;
        private Label label25;
        private Label lblUtilidadAntesintereses;
        private Label label23;
        private Label label24;
        private Label label19;
        private Label label16;
        private Label label22;
    }
}