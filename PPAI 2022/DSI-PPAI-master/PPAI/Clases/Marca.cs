using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Marca
    {
        #region Atributos
        private int id_marca;
        private string nombre;
        private List<Modelo> modelos;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public int getId() { return id_marca; }
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public List<Modelo> getModelos() { return modelos; }
        public void setModelos(List<Modelo> modelos) { this.modelos = modelos; }
        #endregion

        #region Constructor
        public Marca(string nombre, int id)
        {
            this.nombre = nombre;
            this.id_marca = id;
            this.modelos = new List<Modelo>();
        }
        #endregion

        #region Metodos

        //Metodo que permite conocer si el modelo pertenece a la Mrca
        public bool esMiModelo(Modelo modelo) 
        { 
            foreach (Modelo m in modelos) 
            {
                if (m.getNombre() == modelo.getNombre()) return true;
            }

            return false;
        }
        #endregion
    }
}
