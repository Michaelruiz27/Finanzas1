namespace Finanzas
{
    partial class razones_Liquidez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(razones_Liquidez));
            panel1 = new Panel();
            label1 = new Label();
            btnAtras = new PictureBox();
            groupBox1 = new GroupBox();
            lblTotalRcirculante = new Label();
            label11 = new Label();
            lblPasivoCirculante = new Label();
            label9 = new Label();
            lblActivoCirculante = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            btnRealizarOperacion = new Button();
            lblPasCirculante = new Label();
            lblActivCir = new Label();
            label24 = new Label();
            label20 = new Label();
            label18 = new Label();
            groupBox2 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label19 = new Label();
            lblInventario = new Label();
            lblPasiCiculante = new Label();
            label17 = new Label();
            lblActCirculante = new Label();
            label14 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label8 = new Label();
            label21 = new Label();
            lblTptalCapTrabajo = new Label();
            label2 = new Label();
            label3 = new Label();
            label22 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Size = new Size(1270, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 45);
            label1.TabIndex = 8;
            label1.Text = "RAZONES DE LIQUIDEZ";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalRcirculante);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblPasivoCirculante);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblActivoCirculante);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label22);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox1.Location = new Point(19, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 328);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Razón de  Circulante";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTotalRcirculante
            // 
            lblTotalRcirculante.Anchor = AnchorStyles.Top;
            lblTotalRcirculante.AutoSize = true;
            lblTotalRcirculante.BackColor = Color.White;
            lblTotalRcirculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTotalRcirculante.ForeColor = Color.FromArgb(215, 143, 35);
            lblTotalRcirculante.Location = new Point(199, 264);
            lblTotalRcirculante.Name = "lblTotalRcirculante";
            lblTotalRcirculante.Size = new Size(45, 23);
            lblTotalRcirculante.TabIndex = 18;
            lblTotalRcirculante.Text = "0.00";
            lblTotalRcirculante.Click += lblTotalRcirculante_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(35, 55, 80);
            label11.Location = new Point(109, 264);
            label11.Name = "label11";
            label11.Size = new Size(60, 23);
            label11.TabIndex = 16;
            label11.Text = "Total:";
            label11.Click += label11_Click;
            // 
            // lblPasivoCirculante
            // 
            lblPasivoCirculante.Anchor = AnchorStyles.Top;
            lblPasivoCirculante.AutoSize = true;
            lblPasivoCirculante.BackColor = Color.White;
            lblPasivoCirculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPasivoCirculante.ForeColor = Color.FromArgb(35, 55, 80);
            lblPasivoCirculante.Location = new Point(318, 211);
            lblPasivoCirculante.Name = "lblPasivoCirculante";
            lblPasivoCirculante.Size = new Size(45, 23);
            lblPasivoCirculante.TabIndex = 15;
            lblPasivoCirculante.Text = "0.00";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(35, 55, 80);
            label9.Location = new Point(226, 179);
            label9.Name = "label9";
            label9.Size = new Size(280, 23);
            label9.TabIndex = 14;
            label9.Text = "___________________________";
            // 
            // lblActivoCirculante
            // 
            lblActivoCirculante.Anchor = AnchorStyles.Top;
            lblActivoCirculante.AutoSize = true;
            lblActivoCirculante.BackColor = Color.White;
            lblActivoCirculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblActivoCirculante.ForeColor = Color.FromArgb(35, 55, 80);
            lblActivoCirculante.Location = new Point(318, 156);
            lblActivoCirculante.Name = "lblActivoCirculante";
            lblActivoCirculante.Size = new Size(45, 23);
            lblActivoCirculante.TabIndex = 13;
            lblActivoCirculante.Text = "0.00";
            lblActivoCirculante.Click += lblActivoCirculante_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(35, 55, 80);
            label7.Location = new Point(234, 102);
            label7.Name = "label7";
            label7.Size = new Size(206, 23);
            label7.TabIndex = 12;
            label7.Text = "Total Pasivo Circulante";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(35, 55, 80);
            label6.Location = new Point(226, 61);
            label6.Name = "label6";
            label6.Size = new Size(280, 23);
            label6.TabIndex = 11;
            label6.Text = "___________________________";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(35, 55, 80);
            label5.Location = new Point(235, 39);
            label5.Name = "label5";
            label5.Size = new Size(205, 23);
            label5.TabIndex = 10;
            label5.Text = "Total Activo Circulante";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(35, 55, 80);
            label4.Location = new Point(31, 59);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 9;
            label4.Text = "Razón Circulante =";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(11, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 632);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRealizarOperacion);
            groupBox3.Controls.Add(lblPasCirculante);
            groupBox3.Controls.Add(lblActivCir);
            groupBox3.Controls.Add(lblTptalCapTrabajo);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox3.Location = new Point(18, 373);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1131, 197);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Capital de Trabajo";
            // 
            // btnRealizarOperacion
            // 
            btnRealizarOperacion.BackColor = Color.LimeGreen;
            btnRealizarOperacion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRealizarOperacion.ForeColor = Color.Black;
            btnRealizarOperacion.Location = new Point(882, 139);
            btnRealizarOperacion.Name = "btnRealizarOperacion";
            btnRealizarOperacion.Size = new Size(243, 52);
            btnRealizarOperacion.TabIndex = 11;
            btnRealizarOperacion.Text = "Realizar Operaciones";
            btnRealizarOperacion.UseVisualStyleBackColor = false;
            btnRealizarOperacion.Click += btnRealizarOperacion_Click;
            // 
            // lblPasCirculante
            // 
            lblPasCirculante.Anchor = AnchorStyles.Top;
            lblPasCirculante.AutoSize = true;
            lblPasCirculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPasCirculante.ForeColor = Color.FromArgb(35, 55, 80);
            lblPasCirculante.Location = new Point(427, 101);
            lblPasCirculante.Name = "lblPasCirculante";
            lblPasCirculante.Size = new Size(45, 23);
            lblPasCirculante.TabIndex = 18;
            lblPasCirculante.Text = "0.00";
            // 
            // lblActivCir
            // 
            lblActivCir.Anchor = AnchorStyles.Top;
            lblActivCir.AutoSize = true;
            lblActivCir.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblActivCir.ForeColor = Color.FromArgb(35, 55, 80);
            lblActivCir.Location = new Point(235, 101);
            lblActivCir.Name = "lblActivCir";
            lblActivCir.Size = new Size(45, 23);
            lblActivCir.TabIndex = 17;
            lblActivCir.Text = "0.00";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label24.ForeColor = Color.FromArgb(35, 55, 80);
            label24.Location = new Point(353, 101);
            label24.Name = "label24";
            label24.Size = new Size(17, 23);
            label24.TabIndex = 15;
            label24.Text = "-";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(35, 55, 80);
            label20.Location = new Point(227, 56);
            label20.Name = "label20";
            label20.Size = new Size(323, 23);
            label20.TabIndex = 11;
            label20.Text = "Activo Circulante - Pasivo Circulante";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(35, 55, 80);
            label18.Location = new Point(15, 56);
            label18.Name = "label18";
            label18.Size = new Size(184, 23);
            label18.TabIndex = 10;
            label18.Text = "Capital de Trabajo =";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(lblInventario);
            groupBox2.Controls.Add(lblPasiCiculante);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(lblActCirculante);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(31, 58, 93);
            groupBox2.Location = new Point(578, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 328);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prueba del Acido ";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(215, 143, 35);
            label16.Location = new Point(121, 266);
            label16.Name = "label16";
            label16.Size = new Size(45, 23);
            label16.TabIndex = 28;
            label16.Text = "0.00";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(35, 55, 80);
            label15.Location = new Point(30, 264);
            label15.Name = "label15";
            label15.Size = new Size(60, 23);
            label15.TabIndex = 27;
            label15.Text = "Total:";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(35, 55, 80);
            label19.Location = new Point(287, 149);
            label19.Name = "label19";
            label19.Size = new Size(17, 23);
            label19.TabIndex = 26;
            label19.Text = "-";
            // 
            // lblInventario
            // 
            lblInventario.Anchor = AnchorStyles.Top;
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblInventario.ForeColor = Color.FromArgb(35, 55, 80);
            lblInventario.Location = new Point(349, 149);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(45, 23);
            lblInventario.TabIndex = 25;
            lblInventario.Text = "0.00";
            // 
            // lblPasiCiculante
            // 
            lblPasiCiculante.Anchor = AnchorStyles.Top;
            lblPasiCiculante.AutoSize = true;
            lblPasiCiculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPasiCiculante.ForeColor = Color.FromArgb(35, 55, 80);
            lblPasiCiculante.Location = new Point(275, 211);
            lblPasiCiculante.Name = "lblPasiCiculante";
            lblPasiCiculante.Size = new Size(45, 23);
            lblPasiCiculante.TabIndex = 24;
            lblPasiCiculante.Text = "0.00";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(35, 55, 80);
            label17.Location = new Point(121, 179);
            label17.Name = "label17";
            label17.Size = new Size(440, 23);
            label17.TabIndex = 23;
            label17.Text = "___________________________________________";
            // 
            // lblActCirculante
            // 
            lblActCirculante.Anchor = AnchorStyles.Top;
            lblActCirculante.AutoSize = true;
            lblActCirculante.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblActCirculante.ForeColor = Color.FromArgb(35, 55, 80);
            lblActCirculante.Location = new Point(193, 149);
            lblActCirculante.Name = "lblActCirculante";
            lblActCirculante.Size = new Size(45, 23);
            lblActCirculante.TabIndex = 22;
            lblActCirculante.Text = "0.00";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(35, 55, 80);
            label14.Location = new Point(382, 39);
            label14.Name = "label14";
            label14.Size = new Size(97, 23);
            label14.TabIndex = 21;
            label14.Text = "Inventario";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(35, 55, 80);
            label10.Location = new Point(193, 93);
            label10.Name = "label10";
            label10.Size = new Size(201, 23);
            label10.TabIndex = 20;
            label10.Text = "Total PasivoCirculante";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(35, 55, 80);
            label12.Location = new Point(112, 59);
            label12.Name = "label12";
            label12.Size = new Size(440, 23);
            label12.TabIndex = 19;
            label12.Text = "___________________________________________";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(35, 55, 80);
            label13.Location = new Point(121, 39);
            label13.Name = "label13";
            label13.Size = new Size(222, 23);
            label13.TabIndex = 18;
            label13.Text = "Total Activo Circulante  -";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(35, 55, 80);
            label8.Location = new Point(30, 59);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 17;
            label8.Text = "P.A =";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(35, 55, 80);
            label21.Location = new Point(139, 157);
            label21.Name = "label21";
            label21.Size = new Size(60, 23);
            label21.TabIndex = 12;
            label21.Text = "Total:";
            // 
            // lblTptalCapTrabajo
            // 
            lblTptalCapTrabajo.Anchor = AnchorStyles.Top;
            lblTptalCapTrabajo.AutoSize = true;
            lblTptalCapTrabajo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTptalCapTrabajo.ForeColor = Color.FromArgb(219, 147, 10);
            lblTptalCapTrabajo.Location = new Point(235, 157);
            lblTptalCapTrabajo.Name = "lblTptalCapTrabajo";
            lblTptalCapTrabajo.Size = new Size(45, 23);
            lblTptalCapTrabajo.TabIndex = 16;
            lblTptalCapTrabajo.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 155);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 31;
            label2.Text = "$ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 264);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 32;
            label3.Text = "$ ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(175, 264);
            label22.Name = "label22";
            label22.Size = new Size(30, 25);
            label22.TabIndex = 33;
            label22.Text = "$ ";
            // 
            // razones_Liquidez
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 780);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "razones_Liquidez";
            Text = "razones_Liquidez";
            Load += razones_Liquidez_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAtras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnAtras;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblPasivoCirculante;
        private Label label9;
        private Label lblActivoCirculante;
        private Label lblTotalRcirculante;
        private Label label11;
        private GroupBox groupBox2;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label14;
        private Label label19;
        private Label lblInventario;
        private Label lblPasiCiculante;
        private Label label17;
        private Label lblActCirculante;
        private Label label16;
        private Label label15;
        private GroupBox groupBox3;
        private Label label18;
        private Label label20;
        private Label label24;
        private Label lblPasCirculante;
        private Label lblActivCir;
        private Button btnRealizarOperacion;
        private Label lblTptalCapTrabajo;
        private Label label21;
        private Label label22;
        private Label label2;
        private Label label3;
    }
}