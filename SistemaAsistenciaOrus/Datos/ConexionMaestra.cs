﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistenciaOrus.Datos
{
    public class ConexionMaestra
    {
        public static string conexion = @"Data source=DESKTOP-FR27UMF\SQLEXPRESS; Initial Catalog=ORUS369;Integrated Security=false";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State==ConnectionState.Closed)
            {
                conectar.Open();
            }

        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }

        }

    }
}
