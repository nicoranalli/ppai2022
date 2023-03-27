namespace PPAI.Clases
{
    public class Sesion
    {
        #region Atributos
        private Usuario user;

        #endregion

        #region Constructor
        public Sesion(Usuario user)
        {
            this.user = user;
        }
        #endregion

        #region Metodos

        //Metodo que retorna el personal cientifico asociado a la sesion
        public PersonalCientifico obtenerCientifoLog(PersonalCientifico cientifico)
        {
            return user.obtenerCientifico(cientifico);
        }
        #endregion
    }
}
