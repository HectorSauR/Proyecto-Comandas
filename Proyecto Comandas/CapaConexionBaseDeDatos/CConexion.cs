using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaConexionBaseDeDatos
{
    public class CConexion
    {
        SqlConnection Conexion = new SqlConnection("Server =LAPTOP-NETFLE8Q\\SQLEXPRESS; DataBase = DB_Comandas; Integrated Security = true");
        //LAPTOP-NETFLE8Q\\SQLEXPRESS

        //Metodos abrir y cerrar conexion.
        void abrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed) Conexion.Open();
        }

        void cerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
        }

        //Método para ejecutar procedimiento almacenado.

        public void EjectuarPA(string NombrePA, List<CParametros> ListP)
        {
            SqlCommand Cm;

            try// Hace un intento para abrir la conexion y en caso de fallo no sea un error fatal
            {
                abrirConexion();
                Cm = new SqlCommand(NombrePA, Conexion);
                Cm.CommandType = CommandType.StoredProcedure;
                if (ListP != null)
                {
                    for (int i = 0; i < ListP.Count; i++)
                    {
                        if (ListP[i].Dir == ParameterDirection.Input)
                        {
                            Cm.Parameters.AddWithValue(ListP[i].Nom, ListP[i].Val);
                        }
                        if (ListP[i].Dir == ParameterDirection.Output)
                        {
                            Cm.Parameters.Add(ListP[i].Nom, ListP[i].TDato, ListP[i].Tam).Direction = ParameterDirection.Output;
                        }

                    }
                    Cm.ExecuteNonQuery();

                    //-- Recuperar los parametros de salida -- 

                    for (int i = 0; i < ListP.Count; i++)
                    {
                        if (Cm.Parameters[i].Direction == ParameterDirection.Output)
                        {
                            ListP[i].Val = Cm.Parameters[i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            cerrarConexion();
        }
        //-- Método para las consultas en SQL
        public DataTable Listado(string NombrePA, List<CParametros> ListP)
        {
            DataTable DT = new DataTable();
            SqlDataAdapter DA;
            try
            {
                DA = new SqlDataAdapter(NombrePA, Conexion);
                DA.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (ListP != null)
                {
                    for (int i = 0; i < ListP.Count; i++)
                    {
                        DA.SelectCommand.Parameters.AddWithValue(ListP[i].Nom, ListP[i].Val);
                    }
                }
                DA.Fill(DT);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return DT;
        }
    }
}
