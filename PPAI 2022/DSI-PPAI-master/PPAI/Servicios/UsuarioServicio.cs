using PPAI.Repositorio;
using PPAI.Clases;
using System.Collections.Generic;

namespace PPAI.Servicios
{
    public class UsuarioServicio
    {

        #region Atributos

        private readonly UsuarioRepositorio repositorio;

        #endregion

        #region Constructor

        public UsuarioServicio() { repositorio = new UsuarioRepositorio(); }

        #endregion

        #region Metodos

        //Metodo que retorna una lista de usuarios obtenidos de la base de datos
        public List<Usuario> obtenerUsuarios() { return repositorio.obtenerUsuarios(); }
    
        #endregion
    }      
}
