using PPAI.Clases;
using System.Collections.Generic;
using System.Data;

namespace PPAI.Repositorio
{
    public class PersonalCientificoRepositorio
    {
        #region Metodos

        //Metodo que se encarga de crear los objetos obteniendolos de la base de datos
        public List<PersonalCientifico> obtenerCientificos() 
        {
            var cientificos = new List<PersonalCientifico>();

            var sql = $"SELECT p.legajo, p.nombre, p.apellido, p.numero_documento, p.correo_electronico_institucional, p.correo_personal, p.numero_telefono, u.usuario, u.clave " +
                $"FROM PersonalCientifico p LEFT JOIN Usuario u ON p.id_usuario = u.id_usuario";
            var tabla = ConexionBD.GetConexion().ConsultaSQL(sql);

            foreach(DataRow fila in tabla.Rows) 
            {

                var legajo = int.Parse(fila["legajo"].ToString());
                var nombre = fila["nombre"].ToString();
                var apellido = fila["apellido"].ToString();
                var numeroDoc = int.Parse(fila["numero_documento"].ToString());
                var correoI = fila["correo_electronico_institucional"].ToString();
                var correoP = fila["correo_personal"].ToString();
                var telefono = int.Parse(fila["numero_telefono"].ToString());
                var clave = fila["clave"].ToString();
                var nomusu = fila["usuario"].ToString();
                var usuario = new Usuario(clave, nomusu);

                var cientifico = new PersonalCientifico(legajo,nombre,apellido,numeroDoc,correoI,correoP,telefono,usuario);
                cientificos.Add(cientifico);
            }

            return cientificos;
        }

        #endregion
    }
}
