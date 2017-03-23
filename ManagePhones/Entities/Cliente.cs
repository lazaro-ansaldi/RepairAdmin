
namespace Entities
{
    class Cliente
    {
        private int _id;
        private string _nombre;
        private string _apellido;

        #region Properties
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

    }
}
