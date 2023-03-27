using PPAI.Clases;
using PPAI.Repositorio;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Servicios
{
    public class RecursoTecnologicoServicio
    {
        #region Atributos

        private readonly RecursoTecnologicoRepositorio repositorio;

        #endregion

        #region Constructor

        public RecursoTecnologicoServicio() { repositorio = new RecursoTecnologicoRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que retorna una lista con los recursos obtenidos de la base de datos
        public List<RecursoTecnologico> obtenerRecursos() { return repositorio.obtenerRecursos(); }
        
        #endregion
    }
}
