using System;

namespace Entities.Entidades
{
    public class RepairOrder : Entity
    {
        #region Properties
        public bool IsSd { get; set; }
        public bool IsSim { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int NroOrden { get; set; }
        #endregion
    }
}
