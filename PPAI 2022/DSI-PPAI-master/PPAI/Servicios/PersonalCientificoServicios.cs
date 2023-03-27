using PPAI.Clases;
using PPAI.Repositorio;
using System.Collections.Generic;

namespace PPAI.Servicios
{
    public class PersonalCientificoServicios
    {
        #region Atributos

        private readonly PersonalCientificoRepositorio repositorio;

        #endregion

        #region Constructor

        public PersonalCientificoServicios() {repositorio = new PersonalCientificoRepositorio();}

        #endregion

        #region Metodos

        //Retorna una lista de cientificos obtenidos desde la base de datos
        public List<PersonalCientifico> obtenerCientificos() { return repositorio.obtenerCientificos(); }

        #endregion
    }
}
