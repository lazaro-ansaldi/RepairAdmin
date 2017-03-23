using System;

namespace Entities
{
    public class RepairOrder
    {
        private int _nroOrden;
        private DateTime _fechaIngreso;
        private DateTime? _fechaEgreso;
        private bool _isSim;
        private bool _isSd;

        public bool IsSd
        {
            get { return _isSd; }
            set { _isSd = value; }
        }
        public bool IsSim
        {
            get { return _isSim; }
            set { _isSim = value; }
        }
        public DateTime? FechaEgreso
        {
            get { return _fechaEgreso; }
            set { _fechaEgreso = value; }
        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        public int NroOrden
        {
            get { return _nroOrden; }
            set { _nroOrden = value; }
        }
    }
}
