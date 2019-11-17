using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasesDeDatosConexion;
namespace AbstractFactory.Fabrica
{
    class ConexionFabrica
    {
        protected String tipoConexion;

        public ConexionFabrica(String tipoConexion) {
            this.tipoConexion = tipoConexion;
        }

        protected Conexion CreaConexion() {
            if (tipoConexion.ToLower().Equals("Oracle")) {
                return new OracleConexion();
            }
            else if (tipoConexion.ToLower().Equals("SQLServer"))
            {
                return new SQLServerConexion();
            }
            else if (tipoConexion.ToLower().Equals("PostgreSQL"))
            {
                return new PostgresqlConexion();
            }
            else
            {
                return new MySQLConexion();
            }
          
        }
    }
}
