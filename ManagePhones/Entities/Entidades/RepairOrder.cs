using System;

namespace ManagePhones.Entities.Entidades
{
    public class RepairOrder : Entity
    {
        #region Properties
        public bool IsSd { get; set; }
        public bool IsSim { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float? Importe { get; set; }
        public Phone Phone { get; set; }
        public Cliente Cliente { get; set; }
        #endregion

        #region Public Methods
        public string GetFechaEgreso(string formato)
        {
            return (FechaEgreso != null ? FechaEgreso.Value.ToString(formato) : string.Empty);         
        }
        #endregion
    }
}
