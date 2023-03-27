using System;

namespace PPAI.Clases
{
    public abstract class Estado
    {
        #region Atributos
        private int id_estado;
        private string nombre;
        private string ambito;
        private string descripcion;
        private bool esReservable;
        private bool esCancelable;
        #endregion

        #region Constructor
        public Estado(int id_estado,string nombre, string descripcion,string ambito ,bool esReservable, bool esCancelable)
        {
            this.id_estado = id_estado;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esReservable = esReservable;
            this.esCancelable = esCancelable;
        }
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public bool getEsReservable() { return esReservable; }
        public bool getEsCancelable() { return esCancelable; }
        public string getAmbito() { return ambito; }
        public int getId() { return id_estado; }
        public void setId(int id) { this.id_estado = id; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public void setAmbito(string ambito) { this.ambito = ambito; }  
        public void setEsReservable(bool esReservable) { this.esReservable = esReservable; }
        public void setEsCancelable(bool esCancelable) { this.esCancelable = esCancelable; }
        #endregion

        #region Metodos

        //Metodo polimorfico cuya funcionalidad sera redefinida en las subclases
        public abstract void reservar(Turno turno, DateTime fechaActual);
        #endregion
    }
}
