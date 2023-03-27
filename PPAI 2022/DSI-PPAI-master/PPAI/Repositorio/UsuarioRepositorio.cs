using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class UsuarioRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<Usuario> obtenerUsuarios() 
        {   
            var usuarios = new List<Usuario>();

            var sql = $"SELECT usuario,clave FROM Usuario";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows)
            {
                var nombre = fila["usuario"].ToString();
                var contrasenia = fila["clave"].ToString();
                var usuario = new Usuario(contrasenia, nombre);
                usuarios.Add(usuario);
            }

            return usuarios;
        }

        #endregion
    }
}
