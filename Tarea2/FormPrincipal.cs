using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2.Clases;

namespace Tarea2
{
    public partial class FormPrincipal : Form
    {
        // Declaración de listas, objetos, variable necesarias
        List<Empleado> listadoEmpleados;
        Empleado ObjEmpleado;
        StreamReader nomina;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            #region Lectura_Y_SeparacionDatos
            listadoEmpleados = new List<Empleado>();
            // inialización del stream reader
            nomina = new StreamReader("C:/Users/Francisco/Documents/U/progra sistemas computacionales/Nomina.txt");
            try
            {
                using (nomina)
                {
                    string lineaEnArchivo;
                    //comienzo del ciclo que lee y separa los datos
                    while ((lineaEnArchivo = nomina.ReadLine()) != null)
                    {
                        ObjEmpleado = new Empleado();
                        ObjEmpleado.cedulaEmpleado = Convert.ToInt32(lineaEnArchivo.Split(';')[0]);
                        ObjEmpleado.nombreEmpleado = lineaEnArchivo.Split(';')[1];
                        ObjEmpleado.salarioEmpleado = Double.Parse(lineaEnArchivo.Split(';')[2]);
                        ObjEmpleado.TipoNominaEmpleado = Char.Parse(lineaEnArchivo.Split(';')[3]);
                        ObjEmpleado.SectorEmpleado = lineaEnArchivo.Split(';')[4];
                        listadoEmpleados.Add(ObjEmpleado);
                    }
                    //fin del ciclo que lee y separa los datos
                }
            }
            catch (Exception d)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(d.Message);
            }
            #endregion

            #region Punto1
            double SumaSalarios=0;
            var ResultadoPto1 = from emp in listadoEmpleados
                                where emp.SectorEmpleado=="Alajuela"
                                select emp.salarioEmpleado;
            foreach (var datoSalario in ResultadoPto1)
            {
                SumaSalarios = datoSalario + SumaSalarios;
            }
            TxtTotalSalarios.Text= SumaSalarios.ToString();

            #endregion

            #region Punto2
            var ResultadoPto2 = from emp in listadoEmpleados
                                select new {
                                    Salario = emp.salarioEmpleado,
                                    Sector= emp.SectorEmpleado };
            //Variables acumlativas para el siguiente ciclo
            double totalSalSJ = 0;
            double totalSalC = 0;
            double totalSalH = 0;
            double totalSalA = 0;
            double totalSalP = 0;

            #region ciclo para realizar el filtro
            foreach (var provincia in ResultadoPto2)
            {
                string comparacion = provincia.Sector.ToString();
                if (comparacion== "San Jose")
                {
                    totalSalSJ = totalSalSJ + provincia.Salario;
                }
                else if (comparacion == "Puntarenas")
                {
                    totalSalP = totalSalP + provincia.Salario;
                }
                else if (comparacion == "Heredia")
                {
                    totalSalH = totalSalH + provincia.Salario;
                }
                else if (comparacion == "Alajuela")
                {
                    totalSalA = totalSalA + provincia.Salario;
                }
                else if (comparacion == "Cartago")
                {
                    totalSalC = totalSalC + provincia.Salario;
                }
            }
            #endregion

            listSalariosProvincia.Items.Add("San Jose - " + totalSalSJ);
            listSalariosProvincia.Items.Add("Puntarenas - " + totalSalP);
            listSalariosProvincia.Items.Add("Heredia - " + totalSalH);
            listSalariosProvincia.Items.Add("Alajuela - " + totalSalA);
            listSalariosProvincia.Items.Add("Cartago - " + totalSalC);
            #endregion

            #region Punto3

            var ResultadoPto3 = from emp in listadoEmpleados
                                select new { Salario = emp.salarioEmpleado, Tipo= emp.TipoNominaEmpleado };
            int contTipoB=0;
            double totalSalarioTipoB=0;

            #region CicloSumaDeCamposParaSacarPromedio
            foreach (var item in ResultadoPto3)
            {
                if (item.Tipo == 'B')
                {
                    contTipoB = contTipoB + 1;
                    totalSalarioTipoB = totalSalarioTipoB + item.Salario;
                }
                else
                {
                    Console.Write("punto 3-no es tipo B");
                }
            }
            #endregion

            double PromedioSalTipoB = totalSalarioTipoB / contTipoB;

            TxtSalTipoB.Text = PromedioSalTipoB.ToString();
            #endregion

            #region Punto4
            double NominaMayor = 0;
            double nominaA = 0;
            double nominaB = 0;
            double nominaC = 0;
            double nominaD = 0;

            #region Ciclo_Acumulacion_En_Nominas
            foreach (var item4 in ResultadoPto3)
            {
                if (item4.Tipo == 'A')
                {
                    nominaA = nominaA + item4.Salario;
                }
                else if (item4.Tipo == 'B')
                {
                    nominaB = nominaB + item4.Salario;
                }
                else if (item4.Tipo == 'C')
                {
                    nominaC = nominaC + item4.Salario;
                }
                else if (item4.Tipo == 'D')
                {
                    nominaD = nominaD + item4.Salario;
                }
                else
                {
                    Console.Write("punto 4-esa nomina no ha sido reconocida");
                }
            }
            #endregion

            #region ComparacionEntreNominas

            if (NominaMayor < nominaA)
            {
                NominaMayor = nominaA;
                if (NominaMayor < nominaB)
                {
                    NominaMayor = nominaB;
                }

                if (NominaMayor < nominaC)
                {
                    NominaMayor = nominaC;
                }

                if (NominaMayor < nominaD)
                {
                    NominaMayor = nominaD;
                }
            }
            #endregion

            TxtNomSalsAlta.Text = NominaMayor.ToString();
            #endregion
        }

    }
    }

