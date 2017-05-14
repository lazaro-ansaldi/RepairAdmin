using System.Collections.Generic;

namespace ManagePhones.Entities.Entidades
{
    public class Phone : Entity
    {
        #region Constructors
        public Phone()
        {
            Ordenes = new List<RepairOrder>();
        }
        #endregion

        #region Properties
        public List<RepairOrder> Ordenes { get; set; }
        public string Imei { get; set; }
        public string Descripcion { get; set; }
        public Modelo Modelo { get; set; }
        #endregion
    }
}
