using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacios_lV_Grupo6.Controlador
{
    public class BDGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
           //Realiza la conexion con la base de datos, solo deben cambiar su direccion de almacenamiento por el de ustedes
           SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDRegistroProgralV;Data Source=Mini-Shev\\MSSQLSERVER01");
           conexion.Open();

           return conexion;
        }

    }
}
