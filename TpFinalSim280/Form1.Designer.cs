
using System;
using System.Windows.Forms;

namespace TpFinalSim280
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private IGeneradorNumerosAleatorios _generadorAleatorio;
        //private IDistribucion _distribucion;
        //private GestorEstadistico _gestor;
        //private const int Decimales = 3;

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
            this.gbDistribucion = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMargenBU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMargenAU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDExponencial = new System.Windows.Forms.RadioButton();
            this.rbDNormal = new System.Windows.Forms.RadioButton();
            this.rbDUniforme = new System.Windows.Forms.RadioButton();
            this.gbGeneradores = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSumatorioC = new System.Windows.Forms.TextBox();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.txtCantNro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDivisorM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiplicativoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSemillaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGSistema = new System.Windows.Forms.RadioButton();
            this.rbGCMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbGCMixto = new System.Windows.Forms.RadioButton();
            this.dgvResultadosDistribucion = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParamModelo = new System.Windows.Forms.GroupBox();
            this.btnParamModelo = new System.Windows.Forms.Button();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtNroRestricciones = new System.Windows.Forms.TextBox();
            this.txtNroVariables = new System.Windows.Forms.TextBox();
            this.lblNumeroRestricciones = new System.Windows.Forms.Label();
            this.lblNroVariables = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionZ = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvRestriciones = new System.Windows.Forms.DataGridView();
            this.lblcondionZero = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblCantMostrar = new System.Windows.Forms.Label();
            this.txtCantMostrar = new System.Windows.Forms.TextBox();
            this.lblCantIteraciones = new System.Windows.Forms.Label();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.txtCantIteraciones = new System.Windows.Forms.TextBox();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.tabParametros = new System.Windows.Forms.TabControl();
            this.tabParam = new System.Windows.Forms.TabPage();
            this.gbProcesamiento = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtZOptima = new System.Windows.Forms.RichTextBox();
            this.txtVariablesOptimas = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtFuncionZDisplay = new System.Windows.Forms.RichTextBox();
            this.txtRestriccionesDisplay = new System.Windows.Forms.RichTextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.gbDistribucion.SuspendLayout();
            this.gbGeneradores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosDistribucion)).BeginInit();
            this.gbParamModelo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionZ)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestriciones)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabParametros.SuspendLayout();
            this.tabParam.SuspendLayout();
            this.gbProcesamiento.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDistribucion
            // 
            this.gbDistribucion.Controls.Add(this.btnGenerar);
            this.gbDistribucion.Controls.Add(this.txtLambda);
            this.gbDistribucion.Controls.Add(this.label10);
            this.gbDistribucion.Controls.Add(this.txtVarianza);
            this.gbDistribucion.Controls.Add(this.label9);
            this.gbDistribucion.Controls.Add(this.txtMedia);
            this.gbDistribucion.Controls.Add(this.label8);
            this.gbDistribucion.Controls.Add(this.txtMargenBU);
            this.gbDistribucion.Controls.Add(this.label7);
            this.gbDistribucion.Controls.Add(this.txtMargenAU);
            this.gbDistribucion.Controls.Add(this.label5);
            this.gbDistribucion.Controls.Add(this.rbDExponencial);
            this.gbDistribucion.Controls.Add(this.rbDNormal);
            this.gbDistribucion.Controls.Add(this.rbDUniforme);
            this.gbDistribucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDistribucion.Location = new System.Drawing.Point(874, 20);
            this.gbDistribucion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbDistribucion.Name = "gbDistribucion";
            this.gbDistribucion.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbDistribucion.Size = new System.Drawing.Size(515, 183);
            this.gbDistribucion.TabIndex = 12;
            this.gbDistribucion.TabStop = false;
            this.gbDistribucion.Text = "Distribución: ";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(386, 117);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(121, 54);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar ";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btn_PuntoC_Click);
            // 
            // txtLambda
            // 
            this.txtLambda.Enabled = false;
            this.txtLambda.Location = new System.Drawing.Point(311, 119);
            this.txtLambda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(60, 22);
            this.txtLambda.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lambda:";
            // 
            // txtVarianza
            // 
            this.txtVarianza.Enabled = false;
            this.txtVarianza.Location = new System.Drawing.Point(311, 81);
            this.txtVarianza.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.Size = new System.Drawing.Size(60, 22);
            this.txtVarianza.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Varianza:";
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(311, 47);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(60, 22);
            this.txtMedia.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Media:";
            // 
            // txtMargenBU
            // 
            this.txtMargenBU.Enabled = false;
            this.txtMargenBU.Location = new System.Drawing.Point(427, 82);
            this.txtMargenBU.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMargenBU.Name = "txtMargenBU";
            this.txtMargenBU.Size = new System.Drawing.Size(60, 22);
            this.txtMargenBU.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "B:";
            // 
            // txtMargenAU
            // 
            this.txtMargenAU.Enabled = false;
            this.txtMargenAU.Location = new System.Drawing.Point(427, 47);
            this.txtMargenAU.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMargenAU.Name = "txtMargenAU";
            this.txtMargenAU.Size = new System.Drawing.Size(60, 22);
            this.txtMargenAU.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "A:";
            // 
            // rbDExponencial
            // 
            this.rbDExponencial.AutoSize = true;
            this.rbDExponencial.Location = new System.Drawing.Point(8, 117);
            this.rbDExponencial.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbDExponencial.Name = "rbDExponencial";
            this.rbDExponencial.Size = new System.Drawing.Size(155, 21);
            this.rbDExponencial.TabIndex = 11;
            this.rbDExponencial.Text = "Exponencial Inversa";
            this.rbDExponencial.UseVisualStyleBackColor = true;
            this.rbDExponencial.CheckedChanged += new System.EventHandler(this.rad_exponencial_CheckedChanged);
            // 
            // rbDNormal
            // 
            this.rbDNormal.AutoSize = true;
            this.rbDNormal.Location = new System.Drawing.Point(8, 84);
            this.rbDNormal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbDNormal.Name = "rbDNormal";
            this.rbDNormal.Size = new System.Drawing.Size(74, 21);
            this.rbDNormal.TabIndex = 10;
            this.rbDNormal.Text = "Normal";
            this.rbDNormal.UseVisualStyleBackColor = true;
            this.rbDNormal.CheckedChanged += new System.EventHandler(this.rad_normal_CheckedChanged);
            // 
            // rbDUniforme
            // 
            this.rbDUniforme.AutoSize = true;
            this.rbDUniforme.Location = new System.Drawing.Point(8, 51);
            this.rbDUniforme.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbDUniforme.Name = "rbDUniforme";
            this.rbDUniforme.Size = new System.Drawing.Size(86, 21);
            this.rbDUniforme.TabIndex = 9;
            this.rbDUniforme.Text = "Uniforme";
            this.rbDUniforme.UseVisualStyleBackColor = true;
            this.rbDUniforme.CheckedChanged += new System.EventHandler(this.rad_uniforme_CheckedChanged);
            // 
            // gbGeneradores
            // 
            this.gbGeneradores.Controls.Add(this.groupBox2);
            this.gbGeneradores.Controls.Add(this.groupBox1);
            this.gbGeneradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeneradores.Location = new System.Drawing.Point(7, 20);
            this.gbGeneradores.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbGeneradores.Name = "gbGeneradores";
            this.gbGeneradores.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbGeneradores.Size = new System.Drawing.Size(859, 183);
            this.gbGeneradores.TabIndex = 13;
            this.gbGeneradores.TabStop = false;
            this.gbGeneradores.Text = "Números aleatorios: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSumatorioC);
            this.groupBox2.Controls.Add(this.txtIntervalos);
            this.groupBox2.Controls.Add(this.txtCantNro);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDivisorM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMultiplicativoA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSemillaA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(444, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(404, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            // 
            // txtSumatorioC
            // 
            this.txtSumatorioC.Enabled = false;
            this.txtSumatorioC.Location = new System.Drawing.Point(335, 28);
            this.txtSumatorioC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSumatorioC.Name = "txtSumatorioC";
            this.txtSumatorioC.Size = new System.Drawing.Size(60, 22);
            this.txtSumatorioC.TabIndex = 4;
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(335, 99);
            this.txtIntervalos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(60, 22);
            this.txtIntervalos.TabIndex = 8;
            // 
            // txtCantNro
            // 
            this.txtCantNro.Location = new System.Drawing.Point(146, 97);
            this.txtCantNro.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCantNro.Name = "txtCantNro";
            this.txtCantNro.Size = new System.Drawing.Size(60, 22);
            this.txtCantNro.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Intervalos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sumatorio C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cant. Nro:";
            // 
            // txtDivisorM
            // 
            this.txtDivisorM.Enabled = false;
            this.txtDivisorM.Location = new System.Drawing.Point(335, 64);
            this.txtDivisorM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDivisorM.Name = "txtDivisorM";
            this.txtDivisorM.Size = new System.Drawing.Size(60, 22);
            this.txtDivisorM.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Divisor M:";
            // 
            // txtMultiplicativoA
            // 
            this.txtMultiplicativoA.Enabled = false;
            this.txtMultiplicativoA.Location = new System.Drawing.Point(146, 64);
            this.txtMultiplicativoA.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMultiplicativoA.Name = "txtMultiplicativoA";
            this.txtMultiplicativoA.Size = new System.Drawing.Size(60, 22);
            this.txtMultiplicativoA.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiplicativo A:";
            // 
            // txtSemillaA
            // 
            this.txtSemillaA.Enabled = false;
            this.txtSemillaA.Location = new System.Drawing.Point(146, 32);
            this.txtSemillaA.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSemillaA.Name = "txtSemillaA";
            this.txtSemillaA.Size = new System.Drawing.Size(60, 22);
            this.txtSemillaA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semilla:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGSistema);
            this.groupBox1.Controls.Add(this.rbGCMultiplicativo);
            this.groupBox1.Controls.Add(this.rbGCMixto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(416, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generadores";
            // 
            // rbGSistema
            // 
            this.rbGSistema.AutoSize = true;
            this.rbGSistema.Location = new System.Drawing.Point(7, 96);
            this.rbGSistema.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbGSistema.Name = "rbGSistema";
            this.rbGSistema.Size = new System.Drawing.Size(173, 21);
            this.rbGSistema.TabIndex = 2;
            this.rbGSistema.Text = "Generador del sistema";
            this.rbGSistema.UseVisualStyleBackColor = true;
            this.rbGSistema.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbGCMultiplicativo
            // 
            this.rbGCMultiplicativo.AutoSize = true;
            this.rbGCMultiplicativo.Location = new System.Drawing.Point(7, 62);
            this.rbGCMultiplicativo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbGCMultiplicativo.Name = "rbGCMultiplicativo";
            this.rbGCMultiplicativo.Size = new System.Drawing.Size(354, 21);
            this.rbGCMultiplicativo.TabIndex = 1;
            this.rbGCMultiplicativo.Text = "Congruencial Multiplicativo - Xn = (A * Xn-1 ) Mod M";
            this.rbGCMultiplicativo.UseVisualStyleBackColor = true;
            this.rbGCMultiplicativo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbGCMixto
            // 
            this.rbGCMixto.AutoSize = true;
            this.rbGCMixto.Location = new System.Drawing.Point(7, 28);
            this.rbGCMixto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbGCMixto.Name = "rbGCMixto";
            this.rbGCMixto.Size = new System.Drawing.Size(331, 21);
            this.rbGCMixto.TabIndex = 0;
            this.rbGCMixto.Text = "Congruencial Mixto - Xn = (A * Xn-1 + C ) Mod M";
            this.rbGCMixto.UseVisualStyleBackColor = true;
            this.rbGCMixto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // dgvResultadosDistribucion
            // 
            this.dgvResultadosDistribucion.AllowUserToAddRows = false;
            this.dgvResultadosDistribucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadosDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosDistribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.numero});
            this.dgvResultadosDistribucion.Location = new System.Drawing.Point(1185, 220);
            this.dgvResultadosDistribucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResultadosDistribucion.Name = "dgvResultadosDistribucion";
            this.dgvResultadosDistribucion.RowTemplate.Height = 24;
            this.dgvResultadosDistribucion.Size = new System.Drawing.Size(204, 254);
            this.dgvResultadosDistribucion.TabIndex = 14;
            this.dgvResultadosDistribucion.Visible = false;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posición";
            this.posicion.Name = "posicion";
            // 
            // numero
            // 
            this.numero.HeaderText = "Números";
            this.numero.Name = "numero";
            // 
            // gbParamModelo
            // 
            this.gbParamModelo.Controls.Add(this.btnParamModelo);
            this.gbParamModelo.Controls.Add(this.cmbFuncion);
            this.gbParamModelo.Controls.Add(this.lblFuncion);
            this.gbParamModelo.Controls.Add(this.txtNroRestricciones);
            this.gbParamModelo.Controls.Add(this.txtNroVariables);
            this.gbParamModelo.Controls.Add(this.lblNumeroRestricciones);
            this.gbParamModelo.Controls.Add(this.lblNroVariables);
            this.gbParamModelo.Location = new System.Drawing.Point(5, 220);
            this.gbParamModelo.Name = "gbParamModelo";
            this.gbParamModelo.Size = new System.Drawing.Size(775, 86);
            this.gbParamModelo.TabIndex = 15;
            this.gbParamModelo.TabStop = false;
            this.gbParamModelo.Text = "Parámetros Modelo";
            // 
            // btnParamModelo
            // 
            this.btnParamModelo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnParamModelo.Location = new System.Drawing.Point(658, 13);
            this.btnParamModelo.Name = "btnParamModelo";
            this.btnParamModelo.Size = new System.Drawing.Size(111, 62);
            this.btnParamModelo.TabIndex = 20;
            this.btnParamModelo.Text = "PROCESAR";
            this.btnParamModelo.UseVisualStyleBackColor = false;
            this.btnParamModelo.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbFuncion.Items.AddRange(new object[] {
            "MAX",
            "MIN"});
            this.cmbFuncion.Location = new System.Drawing.Point(517, 35);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(121, 24);
            this.cmbFuncion.TabIndex = 19;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(449, 39);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(62, 17);
            this.lblFuncion.TabIndex = 15;
            this.lblFuncion.Text = "Función:";
            // 
            // txtNroRestricciones
            // 
            this.txtNroRestricciones.Location = new System.Drawing.Point(370, 35);
            this.txtNroRestricciones.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNroRestricciones.Name = "txtNroRestricciones";
            this.txtNroRestricciones.Size = new System.Drawing.Size(60, 22);
            this.txtNroRestricciones.TabIndex = 18;
            // 
            // txtNroVariables
            // 
            this.txtNroVariables.Location = new System.Drawing.Point(146, 35);
            this.txtNroVariables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNroVariables.Name = "txtNroVariables";
            this.txtNroVariables.Size = new System.Drawing.Size(60, 22);
            this.txtNroVariables.TabIndex = 17;
            // 
            // lblNumeroRestricciones
            // 
            this.lblNumeroRestricciones.AutoSize = true;
            this.lblNumeroRestricciones.Location = new System.Drawing.Point(219, 38);
            this.lblNumeroRestricciones.Name = "lblNumeroRestricciones";
            this.lblNumeroRestricciones.Size = new System.Drawing.Size(144, 17);
            this.lblNumeroRestricciones.TabIndex = 1;
            this.lblNumeroRestricciones.Text = "Nro de Restricciones:";
            // 
            // lblNroVariables
            // 
            this.lblNroVariables.AutoSize = true;
            this.lblNroVariables.Location = new System.Drawing.Point(23, 38);
            this.lblNroVariables.Name = "lblNroVariables";
            this.lblNroVariables.Size = new System.Drawing.Size(116, 17);
            this.lblNroVariables.TabIndex = 0;
            this.lblNroVariables.Text = "Nro de variables:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvFuncionZ);
            this.groupBox6.Location = new System.Drawing.Point(5, 312);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(775, 100);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Funcion Z";
            // 
            // dgvFuncionZ
            // 
            this.dgvFuncionZ.AllowUserToAddRows = false;
            this.dgvFuncionZ.AllowUserToDeleteRows = false;
            this.dgvFuncionZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionZ.Location = new System.Drawing.Point(26, 22);
            this.dgvFuncionZ.Name = "dgvFuncionZ";
            this.dgvFuncionZ.RowTemplate.Height = 24;
            this.dgvFuncionZ.Size = new System.Drawing.Size(724, 72);
            this.dgvFuncionZ.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvRestriciones);
            this.groupBox7.Controls.Add(this.lblcondionZero);
            this.groupBox7.Location = new System.Drawing.Point(5, 418);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(775, 289);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Restricciones";
            // 
            // dgvRestriciones
            // 
            this.dgvRestriciones.AllowUserToAddRows = false;
            this.dgvRestriciones.AllowUserToDeleteRows = false;
            this.dgvRestriciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestriciones.Location = new System.Drawing.Point(26, 29);
            this.dgvRestriciones.Name = "dgvRestriciones";
            this.dgvRestriciones.RowTemplate.Height = 24;
            this.dgvRestriciones.Size = new System.Drawing.Size(724, 236);
            this.dgvRestriciones.TabIndex = 22;
            // 
            // lblcondionZero
            // 
            this.lblcondionZero.AutoSize = true;
            this.lblcondionZero.Location = new System.Drawing.Point(23, 268);
            this.lblcondionZero.Name = "lblcondionZero";
            this.lblcondionZero.Size = new System.Drawing.Size(18, 17);
            this.lblcondionZero.TabIndex = 0;
            this.lblcondionZero.Text = "--";
            this.lblcondionZero.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblCantMostrar);
            this.groupBox8.Controls.Add(this.txtCantMostrar);
            this.groupBox8.Controls.Add(this.lblCantIteraciones);
            this.groupBox8.Controls.Add(this.lblMostrarDesde);
            this.groupBox8.Controls.Add(this.txtCantIteraciones);
            this.groupBox8.Controls.Add(this.txtMostrarDesde);
            this.groupBox8.Location = new System.Drawing.Point(800, 220);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(367, 174);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Configuracion";
            // 
            // lblCantMostrar
            // 
            this.lblCantMostrar.AutoSize = true;
            this.lblCantMostrar.Location = new System.Drawing.Point(19, 124);
            this.lblCantMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantMostrar.Name = "lblCantMostrar";
            this.lblCantMostrar.Size = new System.Drawing.Size(132, 17);
            this.lblCantMostrar.TabIndex = 9;
            this.lblCantMostrar.Text = "Cantidad a Mostrar:";
            // 
            // txtCantMostrar
            // 
            this.txtCantMostrar.Location = new System.Drawing.Point(173, 119);
            this.txtCantMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantMostrar.Name = "txtCantMostrar";
            this.txtCantMostrar.Size = new System.Drawing.Size(69, 22);
            this.txtCantMostrar.TabIndex = 25;
            this.txtCantMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantMostrar.TextChanged += new System.EventHandler(this.Validar_txtCantMostrar);
            // 
            // lblCantIteraciones
            // 
            this.lblCantIteraciones.AutoSize = true;
            this.lblCantIteraciones.Location = new System.Drawing.Point(19, 49);
            this.lblCantIteraciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantIteraciones.Name = "lblCantIteraciones";
            this.lblCantIteraciones.Size = new System.Drawing.Size(141, 17);
            this.lblCantIteraciones.TabIndex = 0;
            this.lblCantIteraciones.Text = "Cantidad Iteraciones:";
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.Location = new System.Drawing.Point(19, 87);
            this.lblMostrarDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(105, 17);
            this.lblMostrarDesde.TabIndex = 1;
            this.lblMostrarDesde.Text = "Mostrar Desde:";
            // 
            // txtCantIteraciones
            // 
            this.txtCantIteraciones.Location = new System.Drawing.Point(173, 44);
            this.txtCantIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantIteraciones.Name = "txtCantIteraciones";
            this.txtCantIteraciones.Size = new System.Drawing.Size(68, 22);
            this.txtCantIteraciones.TabIndex = 23;
            this.txtCantIteraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Location = new System.Drawing.Point(173, 82);
            this.txtMostrarDesde.Margin = new System.Windows.Forms.Padding(4);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(68, 22);
            this.txtMostrarDesde.TabIndex = 24;
            this.txtMostrarDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMostrarDesde.TextChanged += new System.EventHandler(this.Validar_txtMostrarDesde);
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSimular.Location = new System.Drawing.Point(983, 400);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(184, 74);
            this.btnSimular.TabIndex = 26;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimularClick);
            // 
            // tabParametros
            // 
            this.tabParametros.Controls.Add(this.tabParam);
            this.tabParametros.Controls.Add(this.tabResult);
            this.tabParametros.Location = new System.Drawing.Point(13, 11);
            this.tabParametros.Name = "tabParametros";
            this.tabParametros.SelectedIndex = 0;
            this.tabParametros.Size = new System.Drawing.Size(1511, 790);
            this.tabParametros.TabIndex = 18;
            // 
            // tabParam
            // 
            this.tabParam.AccessibleName = "tabParametros";
            this.tabParam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabParam.Controls.Add(this.gbProcesamiento);
            this.tabParam.Controls.Add(this.gbGeneradores);
            this.tabParam.Controls.Add(this.groupBox7);
            this.tabParam.Controls.Add(this.btnSimular);
            this.tabParam.Controls.Add(this.groupBox8);
            this.tabParam.Controls.Add(this.gbDistribucion);
            this.tabParam.Controls.Add(this.dgvResultadosDistribucion);
            this.tabParam.Controls.Add(this.gbParamModelo);
            this.tabParam.Controls.Add(this.groupBox6);
            this.tabParam.Location = new System.Drawing.Point(4, 25);
            this.tabParam.Name = "tabParam";
            this.tabParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabParam.Size = new System.Drawing.Size(1503, 761);
            this.tabParam.TabIndex = 0;
            this.tabParam.Text = "Parámetros";
            // 
            // gbProcesamiento
            // 
            this.gbProcesamiento.Controls.Add(this.label18);
            this.gbProcesamiento.Controls.Add(this.progressbar);
            this.gbProcesamiento.Location = new System.Drawing.Point(800, 496);
            this.gbProcesamiento.Name = "gbProcesamiento";
            this.gbProcesamiento.Size = new System.Drawing.Size(589, 159);
            this.gbProcesamiento.TabIndex = 19;
            this.gbProcesamiento.TabStop = false;
            this.gbProcesamiento.Text = "Procesamiento Modelo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Progreso:";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(25, 68);
            this.progressbar.MarqueeAnimationSpeed = 1000;
            this.progressbar.Maximum = 1000;
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(536, 76);
            this.progressbar.Step = 1;
            this.progressbar.TabIndex = 18;
            // 
            // tabResult
            // 
            this.tabResult.AccessibleName = "tabResultados";
            this.tabResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabResult.Controls.Add(this.groupBox10);
            this.tabResult.Controls.Add(this.groupBox9);
            this.tabResult.Controls.Add(this.dgvResultados);
            this.tabResult.Location = new System.Drawing.Point(4, 25);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(1503, 761);
            this.tabResult.TabIndex = 1;
            this.tabResult.Text = "Resultados";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtZOptima);
            this.groupBox10.Controls.Add(this.txtVariablesOptimas);
            this.groupBox10.Location = new System.Drawing.Point(499, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(467, 146);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Resultados";
            // 
            // txtZOptima
            // 
            this.txtZOptima.Enabled = false;
            this.txtZOptima.Location = new System.Drawing.Point(6, 21);
            this.txtZOptima.Name = "txtZOptima";
            this.txtZOptima.Size = new System.Drawing.Size(453, 32);
            this.txtZOptima.TabIndex = 3;
            this.txtZOptima.Text = "";
            // 
            // txtVariablesOptimas
            // 
            this.txtVariablesOptimas.Enabled = false;
            this.txtVariablesOptimas.Location = new System.Drawing.Point(6, 59);
            this.txtVariablesOptimas.Name = "txtVariablesOptimas";
            this.txtVariablesOptimas.Size = new System.Drawing.Size(453, 77);
            this.txtVariablesOptimas.TabIndex = 4;
            this.txtVariablesOptimas.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtFuncionZDisplay);
            this.groupBox9.Controls.Add(this.txtRestriccionesDisplay);
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(467, 146);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Problema Analizado";
            // 
            // txtFuncionZDisplay
            // 
            this.txtFuncionZDisplay.Enabled = false;
            this.txtFuncionZDisplay.Location = new System.Drawing.Point(6, 21);
            this.txtFuncionZDisplay.Name = "txtFuncionZDisplay";
            this.txtFuncionZDisplay.Size = new System.Drawing.Size(453, 32);
            this.txtFuncionZDisplay.TabIndex = 1;
            this.txtFuncionZDisplay.Text = "";
            // 
            // txtRestriccionesDisplay
            // 
            this.txtRestriccionesDisplay.Enabled = false;
            this.txtRestriccionesDisplay.Location = new System.Drawing.Point(6, 59);
            this.txtRestriccionesDisplay.Name = "txtRestriccionesDisplay";
            this.txtRestriccionesDisplay.Size = new System.Drawing.Size(453, 77);
            this.txtRestriccionesDisplay.TabIndex = 2;
            this.txtRestriccionesDisplay.Text = "";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResultados.Location = new System.Drawing.Point(6, 158);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(1480, 597);
            this.dgvResultados.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 822);
            this.Controls.Add(this.tabParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SIM: TP final. Ejercicio 280 - Federico Lopez - Legajo: 55025";
            this.gbDistribucion.ResumeLayout(false);
            this.gbDistribucion.PerformLayout();
            this.gbGeneradores.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosDistribucion)).EndInit();
            this.gbParamModelo.ResumeLayout(false);
            this.gbParamModelo.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionZ)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestriciones)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabParametros.ResumeLayout(false);
            this.tabParam.ResumeLayout(false);
            this.gbProcesamiento.ResumeLayout(false);
            this.gbProcesamiento.PerformLayout();
            this.tabResult.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

       

        private System.Windows.Forms.GroupBox gbDistribucion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMargenBU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMargenAU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDExponencial;
        private System.Windows.Forms.RadioButton rbDNormal;
        private System.Windows.Forms.RadioButton rbDUniforme;
        private System.Windows.Forms.GroupBox gbGeneradores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSumatorioC;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.TextBox txtCantNro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDivisorM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiplicativoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemillaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGSistema;
        private System.Windows.Forms.RadioButton rbGCMultiplicativo;
        private System.Windows.Forms.RadioButton rbGCMixto;
        private System.Windows.Forms.DataGridView dgvResultadosDistribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;

        #endregion

        private GroupBox gbParamModelo;
        private Label lblFuncion;
        private TextBox txtNroRestricciones;
        private TextBox txtNroVariables;
        private Label lblNumeroRestricciones;
        private Label lblNroVariables;
        private ComboBox cmbFuncion;
        private Button btnParamModelo;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label lblcondionZero;
        private DataGridView dgvFuncionZ;
        private DataGridView dgvRestriciones;
        private GroupBox groupBox8;
        private Label lblCantMostrar;
        private TextBox txtCantMostrar;
        private Label lblCantIteraciones;
        private Label lblMostrarDesde;
        private TextBox txtCantIteraciones;
        private TextBox txtMostrarDesde;
        private Button btnSimular;
        private TabControl tabParametros;
        private TabPage tabParam;
        private TabPage tabResult;
        private DataGridView dgvResultados;
        private RichTextBox txtFuncionZDisplay;
        private RichTextBox txtRestriccionesDisplay;
        private RichTextBox txtVariablesOptimas;
        private RichTextBox txtZOptima;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private GroupBox gbProcesamiento;
        private Label label18;
        private ProgressBar progressbar;
    }
}

