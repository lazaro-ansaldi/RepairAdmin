using System.Collections.Generic;

namespace Entities
{
    class Phone
    {
        private string _imei;
        private string _descripcion;
        private int _id;
        private Modelo _modelo;
        private List<RepairOrder> _reparaciones;

        public Phone()
        {
            _reparaciones = new List<RepairOrder>();
        }

        public List<RepairOrder> Ordenes
        {
            get
            {
                return _reparaciones;
            }
            set
            {
                _reparaciones = value;
            }
        }
        public string Imei
        {
            get
            {
                return _imei;
            }
            set
            {
                _imei = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }
        public Modelo Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
