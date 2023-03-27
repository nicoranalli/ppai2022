using System.Collections.Generic;
using System.Data;
using PPAI.Clases;

namespace PPAI.Repositorio
{
    public class TipoRecursoTecnologicoRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<TipoRecursoTecnologico> obtenerTipos() 
        { 
            var tipos = new List<TipoRecursoTecnologico>();

            var sql = $"SELECT id_tipo_rt, nombre FROM TipoRecursoTecnologico";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach (DataRow fila in tabla.Rows) 
            {
                var id_tipo = int.Parse(fila["id_tipo_rt"].ToString());
                var nombre = fila["nombre"].ToString();
                var tipo = new TipoRecursoTecnologico(id_tipo,nombre);
                tipos.Add(tipo);
            }

            return tipos;
        }

        #endregion
    }
}
