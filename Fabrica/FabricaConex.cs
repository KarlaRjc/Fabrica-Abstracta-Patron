using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasesDeDatosConexion;

namespace AbstractFactory.Fabrica
{
    public class FabricaConex : FabricaAbstracta
    {
        private string tipo;

        public FabricaConex(string tipo)
        {
            this.tipo = tipo;
        }

        public override Conexion CreaConexion(string tipo)
        {
            tipo = tipo.ToLower();
            if (tipo.Equals("oracle"))
            {

                return new OracleConexion();
            }
            if (tipo.Equals("sqlserver"))
            {

                return new SQLServerConexion();
            }
            if (tipo.Equals("postgresql"))
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
