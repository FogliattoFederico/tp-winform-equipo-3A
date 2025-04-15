using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database= CATALOGO_P3_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "select\r\n\tA.Id,\r\n\tA.nombre,\r\n\tA.codigo,\r\n\tA.descripcion,\r\n\tM.Descripcion as Marca,\r\n\tC.Descripcion as Categoria,\r\n\tA.Precio,\r\n\tI.ImagenUrl\r\nFROM\t\r\n\tARTICULOS A\r\ninner JOIN\r\n\tMARCAS M ON A.IdMarca = M.Id\r\nleft JOIN\r\n\tCATEGORIAS C on A.IdCategoria = C.Id\r\ninner join\r\n\tIMAGENES I on A.Id = I.IdArticulo";
                comando.CommandText = "select A.Id,A.nombre, A.codigo, A.descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id  LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = Convert.ToDecimal(lector["Precio"]);

                    aux.UrlImagen = new Imagen();
                    aux.UrlImagen.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];

                    //Manejo de moto g sin categoria
                    aux.Categoria = !(lector["Categoria"] is DBNull)
                    ? new Categoria { Descripcion = (string)lector["Categoria"] }
                    : null;

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}

