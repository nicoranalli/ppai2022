using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class ModeloRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<Modelo> obtenerModelos(int marca) 
        {
            var modelos = new List<Modelo>();

            var sql = $"SELECT nombre FROM  Modelo WHERE id_marca = {marca}";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows) 
            {
                var nombre = fila["nombre"].ToString();
                var modelo = new Modelo(nombre);
                modelos.Add(modelo);
            }

            return modelos;
        }

        #endregion
    }
}
