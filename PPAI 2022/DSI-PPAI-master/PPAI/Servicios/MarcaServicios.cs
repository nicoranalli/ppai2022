using PPAI.Repositorio;
using PPAI.Clases;
using System.Collections.Generic;

namespace PPAI.Servicios
{
    public class MarcaServicios
    {
        #region Atributos

        private readonly MarcaRepositorio repositorio;

        #endregion

        #region Constructor
        public MarcaServicios() { repositorio = new MarcaRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que retorna la lista de marcas de la base de datos
        public List<Marca> obtenerMarcas() { return repositorio.obtenerMarcas(); }

        #endregion
    }
}
