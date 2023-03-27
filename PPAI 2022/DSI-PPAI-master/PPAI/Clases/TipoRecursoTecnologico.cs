namespace PPAI.Clases
{
    public class TipoRecursoTecnologico
    {
        #region Atributos
        private int id_tipo;
        private string nombre;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getNombre() { return nombre; }
        public int getIdTipo() { return id_tipo; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setIdTipo(int id_tipo) { this.id_tipo = id_tipo; }
        #endregion

        #region Constructor
        public TipoRecursoTecnologico(int id,string nombre)
        {
            this.nombre = nombre;
            this.id_tipo = id;
        }
        #endregion
    }
}
