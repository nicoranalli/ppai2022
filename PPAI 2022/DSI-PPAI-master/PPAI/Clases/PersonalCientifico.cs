namespace PPAI.Clases
{
    public class PersonalCientifico
    {
        #region Atributos
        private int legajo;
        private string nombre;
        private string apellido;
        private int numeroDocumento;
        private int numeroTelefono;
        private string correoElectronicoInstitucional;
        private string correoPersonal;
        private Usuario usuario;
        #endregion

        #region Accesores - Metodos que permiten acceder a los atributos del objeto
        public int getLegajo() { return legajo; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public int getNumeroDocumento() { return numeroDocumento; }
        public string getCorreoElectronicoInstitucional() { return correoElectronicoInstitucional; }
        public string getCorreoPersonal() { return correoPersonal; }
        public Usuario getUsuario() { return usuario; }
        public void setLegajo(int legajo) { this.legajo = legajo; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setNumeroDocumento(int numeroDocumento) { this.numeroDocumento = numeroDocumento; }
        public void setCorreoElectronicoInstitucional(string correoElectronicoInstitucional) { this.correoElectronicoInstitucional = correoElectronicoInstitucional; }
        public void setCorreoPersonal(string correoPersonal) { this.correoPersonal = correoPersonal; }
        public void setUsuario(Usuario user) { this.usuario = user; }
        public int getNumeroTelefono() { return numeroTelefono; }
        public void setNumeroTelefono(int numero) { this.numeroTelefono = numero; }
        #endregion

        #region Constructor
        public PersonalCientifico(int legajo, string nombre, string apellido, int numeroDocumento, string correoElectronicoInstitucional, string correoPersonal, int numeroTelefono ,Usuario usuario)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroDocumento = numeroDocumento;
            this.correoElectronicoInstitucional = correoElectronicoInstitucional;
            this.correoPersonal = correoPersonal;
            this.numeroTelefono = numeroTelefono;
            this.usuario = usuario;
        }
        public PersonalCientifico(int legajo) 
        { 
            this.legajo = legajo; 
        }
        #endregion

        #region Metodos

        //Retorna un booleano indicando si el usuario pasado como parametro es el usuario del cientifico
        public bool esTuUsuario(Usuario user) { return user.getClave() == usuario.getClave() && user.getUsuario() == usuario.getUsuario(); }
        #endregion
    }
}
