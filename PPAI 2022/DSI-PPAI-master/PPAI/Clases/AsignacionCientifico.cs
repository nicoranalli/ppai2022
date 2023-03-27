using System;
using System.Collections.Generic;

namespace PPAI.Clases
{
    public class AsignacionCientifico
    {
        #region Atributos
        private int id_asignacion;
        private DateTime fechaDesde;
        private DateTime? fechaHasta;
        private PersonalCientifico cientifico;
        private List<Turno> turnos;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public int getIdAsignacion() { return id_asignacion; }
        public DateTime getfechaDesde() { return fechaDesde; }
        public DateTime? getfechaHasta() { return fechaHasta; }
        public void setIdAsignacion(int id_asignacion) {this.id_asignacion = id_asignacion; }
        public void setfechaDesde(DateTime fechaDesde) { this.fechaDesde = fechaDesde; }
        public void setfechaHasta(DateTime fechaHasta) { this.fechaHasta = fechaHasta; }
        public PersonalCientifico getCientifico() { return cientifico; }
        #endregion

        #region Constructor
        public AsignacionCientifico(int id_asignacion,DateTime fechaDesde, PersonalCientifico cientifico)
        {
            this.id_asignacion= id_asignacion;
            this.fechaDesde = fechaDesde;
            this.cientifico = cientifico;
            this.turnos = new List<Turno>();
        }
        public AsignacionCientifico(int id_asignacion,DateTime fechaDesde,DateTime fechaHasta,PersonalCientifico cientifico)
        {
            this.id_asignacion= id_asignacion;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.cientifico = cientifico;
            this.turnos = new List<Turno>();
        }
        #endregion

        #region Metodos

        //Agrega un turno a la  lista de turnos de la asignacion 
        public void agregarTurno(Turno turno) { turnos.Add(turno); }

        //Regresa el mail institucional del cientifico 
        public string obtenerMail() { return cientifico.getCorreoElectronicoInstitucional(); }

        //Regresa el numero de telefono del cientifico
        public string obtenerNumeroTelefono() { return cientifico.getNumeroTelefono().ToString(); }

        //Devuelve un booleano indicando si el cientifico es activo
        public bool esCientificoActivo(PersonalCientifico cientifico) { return fechaHasta == null && cientifico.getLegajo() == this.cientifico.getLegajo();}

        #endregion
    }
}
