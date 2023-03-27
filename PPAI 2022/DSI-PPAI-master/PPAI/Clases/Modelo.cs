using System.Collections.Generic;

namespace PPAI.Clases
{
    public class Modelo
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        #endregion

        #region Constructos
        public Modelo(string nombre) { this.nombre = nombre; }
        #endregion

        #region Metodos

        //Metodo que regresa el nombre de la marca del modelo
        public string mostrarMarca(List<Marca> marcas)
        {
            foreach (Marca marca in marcas) { if (marca.esMiModelo(this)) return marca.getNombre(); }
            return "Sin Marca";
        }
        #endregion
    }
}
