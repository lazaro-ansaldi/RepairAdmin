
namespace Entities
{
    class Modelo
    {
        private int _id;
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
