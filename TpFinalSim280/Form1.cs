using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using NumerosAleatorios;
using NumerosAleatorios.NumerosAleatorios;
using NumerosAleatorios.VariablesAleatorias;
using Simulacion;

namespace TpFinalSim280
{
    public partial class Form1 : Form
    {

        private IGeneradorNumerosAleatorios IGeneradorAleatorio;
        private IDistribucion IDistribucion;
        private GestorEstadistico gestor;
        private int nroRestricciones;
        private int nroVariables;
        private const int Decimales = 4;
        private ManejadorSimulacion manejador;

        public Form1()
        {
            InitializeComponent();
        }


        #region Validaciones Formulario


        private bool FormularioValido()
        {
            var generador = FormularioValidoGenerador();
            var distribucion = FormularioValidoDistribucion();

            return generador && distribucion;
        }

        private bool FormularioValidoGenerador()
        {
            if (rbGSistema.Checked)
                return true;

            int semilla;
            int a;
            int c;
            int m;

            if (!int.TryParse(txtDivisorM.Text, out m) ||
                m <= 0)
            {
                MessageBox.Show(@"El valor de M debe ser un entero positivo");
                txtDivisorM.Focus();
                return false;
            }

            if (!int.TryParse(txtSemillaA.Text, out semilla) ||
                semilla <= 0 || semilla >= m)
            {
                MessageBox.Show(@"El valor de semilla debe ser un entero positivo menor a M");
                txtSemillaA.Focus();
                return false;
            }

            if (!int.TryParse(txtMultiplicativoA.Text, out a) ||
                a <= 0 || a >= m)
            {
                MessageBox.Show(@"El valor de A debe ser un entero positivo menor a M");
                txtMultiplicativoA.Focus();
                return false;
            }

            if (rbGCMixto.Checked && (!int.TryParse(txtSumatorioC.Text, out c) ||
                c <= 0 || c >= m))
            {
                MessageBox.Show(@"El valor de C debe ser un entero positivo menor a M");
                txtSumatorioC.Focus();
                return false;
            }

            return true;
        }

        private bool FormularioValidoDistribucion()
        {
            int muestra;
            int intervalos;
            float alfa;

            if (!int.TryParse(txtCantNro.Text, out muestra)
                || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txtCantNro.Focus();
                return false;
            }

            if (!int.TryParse(txtIntervalos.Text, out intervalos)
                || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txtIntervalos.Focus();
                return false;
            }

            //if (!float.TryParse(txt_chicierto.Text, out alfa)
            //    || alfa <= 0 || alfa >= 1)
            //{
            //    MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
            //    txt_chicierto.Focus();
            //    return false;
            //}

            if (rbDUniforme.Checked)
            {
                float a;
                float b;

                if (!float.TryParse(txtMargenAU.Text, out a))
                {
                    MessageBox.Show(@"El valor de A debe ser un número válido");
                    txtMargenAU.Focus();
                    return false;
                }

                if (!float.TryParse(txtMargenBU.Text, out b) || b <= a)
                {
                    MessageBox.Show(@"El valor de B debe ser mayor que A");
                    txtMargenBU.Focus();
                    return false;
                }
            }

            if (rbDNormal.Checked)
            {
                float media;
                float varianza;

                if (!float.TryParse(txtMedia.Text, out media))
                {
                    MessageBox.Show(@"La Media debe ser un número válido");
                    txtMedia.Focus();
                    return false;
                }

                if (!float.TryParse(txtVarianza.Text, out varianza) || varianza < 0)
                {
                    MessageBox.Show(@"La Varianza no puede ser negativa");
                    txtVarianza.Focus();
                    return false;
                }
            }

            if (rbDExponencial.Checked)
            {
                float lambda;

                if (!float.TryParse(txtLambda.Text, out lambda) || lambda <= 0)
                {
                    MessageBox.Show(@"La Varianza debe ser positiva");
                    txtLambda.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LimpiarDatosGenerador()
        {
            txtSemillaA.Text = "";
            txtMultiplicativoA.Text = "";
            txtSumatorioC.Text = "";
            txtDivisorM.Text = "";
        }

        private void LimpiarDatosDistribucion()
        {
            txtMargenAU.Text = "";
            txtMargenBU.Text = "";
            txtMedia.Text = "";
            txtVarianza.Text = "";
            txtLambda.Text = "";
        }

        private void HabilitarGeneracion()
        {
            var generador = rbGCMixto.Checked || rbGCMultiplicativo.Checked || rbGSistema.Checked;
            var distribucion = rbDUniforme.Checked || rbDNormal.Checked || rbDExponencial.Checked;

            btnGenerar.Enabled = generador && distribucion;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtSemillaA.Enabled = true;
            txtMultiplicativoA.Enabled = true;
            txtSumatorioC.Enabled = true;
            txtDivisorM.Enabled = true;
            LimpiarDatosGenerador();
            txtSemillaA.Focus();
            HabilitarGeneracion();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtSemillaA.Enabled = true;
            txtMultiplicativoA.Enabled = true;
            txtSumatorioC.Enabled = false;
            txtDivisorM.Enabled = true;
            LimpiarDatosGenerador();
            txtSemillaA.Focus();
            HabilitarGeneracion();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtSemillaA.Enabled = false;
            txtMultiplicativoA.Enabled = false;
            txtSumatorioC.Enabled = false;
            txtDivisorM.Enabled = false;
            LimpiarDatosGenerador();
            HabilitarGeneracion();
        }

        private void rad_uniforme_CheckedChanged(object sender, EventArgs e)
        {
            txtMargenAU.Enabled = true;
            txtMargenBU.Enabled = true;
            txtMedia.Enabled = false;
            txtVarianza.Enabled = false;
            txtLambda.Enabled = false;
            LimpiarDatosDistribucion();
            txtMargenAU.Focus();
            HabilitarGeneracion();
        }

        private void rad_normal_CheckedChanged(object sender, EventArgs e)
        {
            txtMargenAU.Enabled = false;
            txtMargenBU.Enabled = false;
            txtMedia.Enabled = true;
            txtVarianza.Enabled = true;
            txtLambda.Enabled = false;
            LimpiarDatosDistribucion();
            txtMedia.Focus();
            HabilitarGeneracion();
        }

        private void rad_exponencial_CheckedChanged(object sender, EventArgs e)
        {
            txtMargenAU.Enabled = false;
            txtMargenBU.Enabled = false;
            txtMedia.Enabled = false;
            txtVarianza.Enabled = false;
            txtLambda.Enabled = true;
            LimpiarDatosDistribucion();
            txtLambda.Focus();
            HabilitarGeneracion();
        }

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            if (FormularioValido())
                GenerarNumeros();
        }

        public void GenerarNumeros()
        {
            dgvResultadosDistribucion.Rows.Clear();

            if (rbGSistema.Checked)
            {
                IGeneradorAleatorio = new GeneradorDelSistema();
            }

            else
            {
                var a = int.Parse(txtMultiplicativoA.Text);
                var m = int.Parse(txtDivisorM.Text);
                var semilla = float.Parse(txtSemillaA.Text);

                //Congruencial Multiplicativo : Xn = (A * Xn-1 ) Mod M
                if (rbGCMultiplicativo.Checked)
                {
                    IGeneradorAleatorio = new CongruencialMultiplicativo(semilla, a, m);
                }

                //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
                else if (rbGCMixto.Checked)
                {
                    var c = int.Parse(txtSumatorioC.Text);
                    IGeneradorAleatorio = new CongruencialMixto(semilla, a, c, m);
                }
            }

            if (rbDUniforme.Checked)
            {
                var a = float.Parse(txtMargenAU.Text);
                var b = float.Parse(txtMargenBU.Text);

                IDistribucion = new DistribucionUniforme(a, b, IGeneradorAleatorio);
            }

            if (rbDNormal.Checked)
            {
                var media = float.Parse(txtMedia.Text);
                var varianza = float.Parse(txtVarianza.Text);

                IDistribucion = new DistribucionNormal(media, varianza, IGeneradorAleatorio);
            }

            if (rbDExponencial.Checked)
            {
                var lambda = float.Parse(txtLambda.Text);

                IDistribucion = new DistribucionExponencialNegativa(lambda, IGeneradorAleatorio);
            }

            var tamañoMuestra = int.Parse(txtCantNro.Text);
            var cantidadIntervalos = int.Parse(txtIntervalos.Text);
            var alfa = (float)0.5;

            try
            {
                gestor = new GestorEstadistico(IDistribucion, tamañoMuestra, cantidadIntervalos, alfa);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                // var grados = int.Parse(txt_IntC.Text) - _distribucion.CantidadParametros() - 1;

                //MessageBox.Show(grados <= 0
                //? @"Grados de libertad insuficientes, utilice más intervalos"
                //: @"Falla la prueba de Chi Cuadrado porque las frecuencias esperadas tienden a cero, utilice menos intervalos");

                txtDivisorM.Focus();
                return;
            }

            //for (var i = 0; i < tamañoMuestra; i++)
            //{
            //    var valor = gestor.Valores[i];

            //    dgvResultadosDistribucion.Rows.Add(i + 1, valor);
            //}

        }



        #endregion


        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nroRestricciones = Convert.ToInt32(txtNroRestricciones.Text);
                nroVariables = Convert.ToInt32(txtNroVariables.Text);
                GenerarTablaFuncionZ();
                GenerarTablaRestricciones();
                lblcondionZero.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void GenerarTablaRestricciones()
        {
            string condicionZero = "";

            dgvRestriciones.Rows.Clear();

            for (int i = 0; i < nroVariables; i++)
            {
                string header = "X" + (i + 1).ToString();
                condicionZero += header + ", ";
                //dt.Columns.Add(header, typeof(String));

                DataGridViewTextBoxColumn variable = new DataGridViewTextBoxColumn();
                variable.HeaderText = header;
                variable.DataPropertyName = header;

                dgvRestriciones.Columns.Add(variable);

            }

            DataGridViewComboBoxColumn signo = new DataGridViewComboBoxColumn();
            var list11 = new List<string>() { "=", ">", ">=", "<", "<=" };
            signo.DataSource = list11;
            signo.HeaderText = "Signo";
            signo.DataPropertyName = "Signo";

            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "";
            name.DataPropertyName = "";

            dgvRestriciones.Columns.AddRange(signo, name);

            for (int i = 0; i < nroRestricciones; i++)
            {
                dgvRestriciones.Rows.Add();
            }

            dgvRestriciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            condicionZero = condicionZero.Substring(0, condicionZero.Length - 2);

            lblcondionZero.Text = condicionZero + " >= 0";
        }

        private void GenerarTablaFuncionZ()
        {
            dgvFuncionZ.Rows.Clear();
            dgvFuncionZ.ColumnCount = nroVariables + 1;
            dgvFuncionZ.RowHeadersVisible = false;
            for (int i = 0; i < nroVariables + 1; i++)
            {
                dgvFuncionZ.Columns[i].Width = 50;
                dgvFuncionZ.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i < nroVariables)
                {
                    dgvFuncionZ.Columns[i].Name = "X" + (i + 1).ToString();
                }
                else
                {
                    dgvFuncionZ.Columns[i].Name = "C";
                }

            }
            string[] row = new string[nroVariables + 2];
            dgvFuncionZ.Rows.Add(row);
            dgvFuncionZ.Rows[0].Height = 20;

        }


        private void btnSimularClick(object sender, EventArgs e)
        {
            ProcesarParametros();

        }

        private void ProcesarParametros()
        {
            // bool respuesta = true;
            //var restriccionesParam = GetRestricciones();
            //var funcionZ = GetFunctionZ();

            //if (cmbFuncion.SelectedValue != null && string.IsNullOrEmpty(txtCantIteraciones.Text) && string.IsNullOrEmpty(txtMostrarDesde.Text) && string.IsNullOrEmpty(txtCantMostrar.Text))
            //{
            //string tipoFuncion = (string)cmbFuncion.SelectedItem.ToString();
            //int cantIteraciones = int.Parse(txtCantIteraciones.Text);
            //int mostrarDesde = int.Parse(txtMostrarDesde.Text);
            //int cantAMostrar = int.Parse(txtCantMostrar.Text);

            string tipoFuncion = "MAX";
            //string tipoFuncion = "MIN";
            int cantIteraciones = 100;
            int mostrarDesde = 0;
            int cantAMostrar = 150;
            Restricciones[] restriccionesParam = GetRestriccionesEjemplo();
            FunctionZ funcionZ = new FunctionZ(new float[2] { 1, 1 }, 120);

            GenerarNumeros();

            Simular(tipoFuncion, cantIteraciones, mostrarDesde, cantAMostrar, restriccionesParam, funcionZ, gestor);
            //}
            //else
            //{
            //    MessageBox.Show("Completar Parámetros para Iniciar Simulacion");
            //    //respuesta = false;
            //}

            //return respuesta;

        }

        private Restricciones[] GetRestricciones()
        {

            Restricciones[] restricciones = new Restricciones[nroRestricciones];
            for (int i = 0; i < nroRestricciones; i++)
            {
                float[] variables = new float[nroVariables];
                float b = (float)(dgvRestriciones.Rows[i].Cells[nroVariables + 1].Value);
                string signo = Convert.ToString(dgvRestriciones.Rows[i].Cells[nroVariables].Value);
                for (int j = 0; j < nroVariables; j++)
                {
                    variables[j] = (float)(dgvRestriciones.Rows[i].Cells[j].Value);
                }
                restricciones[i] = new Restricciones(variables, b, signo);
            }

            return restricciones;
        }

        private FunctionZ GetFunctionZ()
        {
            float[] variablesFuncion = new float[nroVariables];
            for (int i = 0; i < nroVariables; i++)
            {
                variablesFuncion[i] = (float)(dgvFuncionZ.Rows[0].Cells[i].Value);
            }
            float c = (float)(dgvFuncionZ.Rows[0].Cells[nroVariables].Value);

            FunctionZ functionZ = new FunctionZ(variablesFuncion, c);

            return functionZ;

        }

        private void Simular(string tipoFuncion, int cantIteraciones, int mostrarDesde, int cantAMostrar, Restricciones[] restricciones, FunctionZ funcionZ, GestorEstadistico numerosAleatorios)
        {

            dgvResultados.DataSource = new ManejadorSimulacion().Simular(tipoFuncion, cantIteraciones, mostrarDesde, cantAMostrar, restricciones, funcionZ, gestor);

            dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResultados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvResultados.ColumnHeadersDefaultCellStyle.Font = new Font(dgvResultados.Font, FontStyle.Bold);
            dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvResultados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabParametros.SelectTab(tabResult);


        }

        private Restricciones[] GetRestriccionesEjemplo()
        {
            Restricciones[] restriccionesArray = new Restricciones[3];
            Restricciones r1 = new Restricciones();
            r1.sign = "<=";
            r1.b = 70;
            r1.variables = new float[2] { 1, 0 };

            Restricciones r2 = new Restricciones();
            r2.sign = "<=";
            r2.b = 50;
            r2.variables = new float[2] { 0, 1 };

            Restricciones r3 = new Restricciones();
            r3.sign = "<=";
            r3.b = 120;
            r3.variables = new float[2] { 1, 1 };

            restriccionesArray[0] = r1;
            restriccionesArray[1] = r2;
            restriccionesArray[2] = r3;

            return restriccionesArray;
        }
    }
}
