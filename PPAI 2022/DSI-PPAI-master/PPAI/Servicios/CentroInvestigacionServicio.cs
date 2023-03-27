using PPAI.Repositorio;
using PPAI.Clases;
using System.Collections.Generic;

namespace PPAI.Servicios
{
    public class CentroInvestigacionServicio
    {
        #region Atributos

        private readonly CentroInvestigacionRepositorio repositorio;

        #endregion

        #region Constructor

        public CentroInvestigacionServicio() { repositorio = new CentroInvestigacionRepositorio();}

        #endregion

        #region

        //Metodo retorna los centros de investigacion del base de datos
        public List<CentroInvestigacion> obtenerCentros() { return repositorio.obtenerCentros(); }

        #endregion
    }
}
