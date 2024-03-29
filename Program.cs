﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Fabrica;
using AbstractFactory.BasesDeDatosConexion;

namespace AbstractFactory

{
    class Program
    {
        static void Main(string[] args)
        {
            String tipo;
            FabricaConex miFabrica;
            Conexion miConexion;

            Console.WriteLine("Digite la Base de Datos que quiere conectarse.");

            tipo = Console.ReadLine();

            miFabrica = new FabricaConex(tipo);



            miConexion = miFabrica.CreaConexion(tipo);
            String salida=("Estás conectado con la Base de datos: " + miConexion.descripcion());
            Console.Write(salida);
            Console.ReadLine();
        }
    }
}
