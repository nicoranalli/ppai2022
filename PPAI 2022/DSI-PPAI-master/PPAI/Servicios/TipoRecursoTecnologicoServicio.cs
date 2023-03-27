using PPAI.Clases;
using PPAI.Repositorio;
using System.Collections.Generic;

namespace PPAI.Servicios
{
    public class TipoRecursoTecnologicoServicio
    {
        #region Atributos

        private TipoRecursoTecnologicoRepositorio repositorio;

        #endregion

        #region Constructor

        public TipoRecursoTecnologicoServicio() { repositorio = new TipoRecursoTecnologicoRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que retorna los tipos de los recursos obtenidos de la base de datos
        public List<TipoRecursoTecnologico> obtenerTipos() { return repositorio.obtenerTipos(); }

        #endregion
    }
}
