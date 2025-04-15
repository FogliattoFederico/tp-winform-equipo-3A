﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
        public class AccesoDatos
        {
            //PROPIEDADES
            private SqlConnection conexion;
            private SqlCommand comando;
            private SqlDataReader lector;

            public SqlDataReader Lector
            {
                get { return lector; }
            }

            //CONSTRUCTOR
            public AccesoDatos()
            {
                conexion = new SqlConnection("server = .\\SQLEXPRESS; database= CATALOGO_P3_DB; integrated security = true");
                comando = new SqlCommand();
            }

            public void setearConsulta(string consulta)
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }

            public void ejecutarLectura()
            {
                try
                {
                    comando.Connection = conexion;
                    conexion.Open();
                    lector = comando.ExecuteReader();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public void cerrarConexion()
            {
                if (lector != null)
                {
                    lector.Close();
                }
                conexion.Close();
            }
        }
 }
