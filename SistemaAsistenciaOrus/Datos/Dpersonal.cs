﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SistemaAsistenciaOrus.Logica;
using System.Windows.Forms;

namespace SistemaAsistenciaOrus.Datos
{
    public class Dpersonal
    {
        public bool InsertarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal",ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public bool EditarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public bool EliminarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

        public void MostrarPersonal(ref DataTable dt,int desde, int hasta)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPersonal", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde",desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }


        public void BuscarPersonal(ref DataTable dt, int desde, int hasta,string buscador)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarPersonal", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }

    }
}
