using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class CentroInvestigacion
    {
        #region Atributos
        private string nombre;
        private int tiempoAntelacionReserva;
        private int numeroResolucion;
        private List<RecursoTecnologico> recursos;
        private List<AsignacionCientifico> asignaciones;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public int getTiempoAntelacion() { return tiempoAntelacionReserva; }
        public void setTiempoAntelacion(int tiempoAntelacionReserva) { this.tiempoAntelacionReserva = tiempoAntelacionReserva; }
        public int getNumeroResolucion() { return numeroResolucion; }
        public void setRecursos(List<RecursoTecnologico> recursos) { this.recursos = recursos; }
        public void setAsignaciones(List<AsignacionCientifico> asignaciones) { this.asignaciones = asignaciones; }
        #endregion

        #region Constructor
        public CentroInvestigacion(int numeroResolucion,string nombre , int tiempoAntelacionReserva)
        {
            this.nombre = nombre;
            this.numeroResolucion = numeroResolucion;
            this.recursos = new List<RecursoTecnologico>();
            this.asignaciones = new List<AsignacionCientifico>();
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
        }

        #endregion

        #region Metodos

        //Metodo que permite saber si un recurso pertenece al centro
        public bool esMiRecurso(RecursoTecnologico recurso) 
        {
            foreach(RecursoTecnologico r in recursos) 
            {
                if(r.getNumero() == recurso.getNumero()) return true;
            }

            return false;
        }

        //Metodo que permite conocer si un cientifico pertenece actualmente al centro
        public AsignacionCientifico esTuCientificoActual(PersonalCientifico cientifico) 
        {
            foreach (AsignacionCientifico a in asignaciones) 
            {
                if (a.esCientificoActivo(cientifico)) return a;
            }
            
            return null;
        }
        #endregion
    }
}
