namespace PPAI.Clases
{
    public class Usuario
    {
        #region Atributos
        private string clave;
        private string usuario;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public string getClave() { return clave; }
        public void setClave(string clave) { this.clave = clave; }
        public string getUsuario() { return usuario; }
        public void setUsuario(string usuario) { this.usuario = usuario; }
        #endregion

        #region Constructor
        public Usuario(string clave, string usuario)
        {
            this.clave = clave;
            this.usuario = usuario;
        }
        #endregion

        #region Metodos
        
        //Metodod que retorna el cientifico asociado al Usuario
        public PersonalCientifico obtenerCientifico(PersonalCientifico cientifico) 
        {
            if (cientifico.esTuUsuario(this)) return cientifico;
        
            return null;
        }
        #endregion
    }
}
