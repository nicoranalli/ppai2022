using Microsoft.SqlServer.Server;
using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class MarcaRepositorio
    {
        #region Atributos

        private readonly ModeloRepositorio modeloRepositorio;

        #endregion

        #region Constructor
        
        public MarcaRepositorio() { modeloRepositorio = new ModeloRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<Marca> obtenerMarcas() 
        { 
            var marcas = new List<Marca>();

            var sql = $"SELECT nombre,id_marca FROM Marca";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows) 
            {
                var nombre = fila["nombre"].ToString();
                var id = int.Parse(fila["id_marca"].ToString());

                var marca = new Marca(nombre,id);
                marcas.Add(marca);
            }

            foreach (Marca marca in marcas) 
            { 
                var modelos = modeloRepositorio.obtenerModelos(marca.getId());
                marca.setModelos(modelos);
            }

            return marcas;
        
        }

        #endregion
    }
}
