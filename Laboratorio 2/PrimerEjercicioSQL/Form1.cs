using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Siempre poner para sql

namespace PrimerEjercicioSQL
{
    
    public partial class Form1 : Form
    {
        SqlConnection miConexion;//puente
        SqlCommand miComando;//objeto que lleva la consulta
        SqlDataReader InfoDeBaseDeDatos; //Objeto que trae los datos de la base

        DataTable miTablita;
        public Form1()
        {
            //Instanciamos
            miConexion = new SqlConnection(@"Data Source= LAPTOP-GFCNS9AV\SQLEXPRESS; Database = Veterinaria; Trusted_Connection=True;");//Usamos CONEXION STRING--ESTE ES EL PUENTE
            miComando = new SqlCommand();//Hacer consultas a la base de datos

            miTablita = new DataTable();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region propiedades de datagrid

            dtgTabla.ReadOnly = true;//solo lectura, no se puede modificar los datos.
            dtgTabla.RowHeadersVisible = false;//sacamos la columna de flechita
            dtgTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//llenar la datagrid
            dtgTabla.AllowUserToAddRows = false;//quita iltima columna vacia y no deja agregar

            #endregion

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                //UNIR COMANDO CON LA CONEXION
                dtgTabla.DataSource = null;//limpia el datasource
                dtgTabla.Rows.Clear();
                miTablita.Rows.Clear();//Limpia los campos

                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;//tipo de comand que vamo a ejecutar
                miComando.CommandText = "SELECT * FROM Duenio WHERE pais = @paisAFiltrar";

                miComando.Parameters.Clear();

                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();//conexion abierta
                }

                miComando.Parameters.Add(new SqlParameter("paisAFiltrar", int.Parse(txtEdadAFiltrar.Text)));

                
                InfoDeBaseDeDatos = miComando.ExecuteReader();//Se inicializaria de esta manera. lleva y trae la info
                
                miTablita.Load(InfoDeBaseDeDatos);//cargamos la tabla

                dtgTabla.DataSource = miTablita;

          


                #region Consultas a mano

                //while (InfoDeBaseDeDatos.Read())
                //{

                //    auxNombre = InfoDeBaseDeDatos["nombre"].ToString(); recorrer la info a mano
                //    auxApellido = InfoDeBaseDeDatos["edad"].ToString();

                //}
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {

                    miConexion.Close();//Siempre cerrar la conexion
                }
            }
            
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                miComando = new SqlCommand();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "INSERT INTO Duenio VALUES (@dni,@nombre,@direccion,@pais)";
                miComando.Parameters.Add(new SqlParameter("dni", int.Parse(txtEdadAFiltrar.Text)));
                miComando.Parameters.Add(new SqlParameter("nombre", "Oscar Muñoz"));
                miComando.Parameters.Add(new SqlParameter("direccion", "San Telmo"));
                miComando.Parameters.Add(new SqlParameter("pais", "ARGENTINA"));

                miConexion.Open();

                int cantInsertada = miComando.ExecuteNonQuery();//Otra manera de ver la cantidad de insert que hizo
                MessageBox.Show("Cantidad de lineas Insertadas: " + cantInsertada);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
            


            


        }
    }
}
