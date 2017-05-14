
using System.Collections.Generic;

namespace ManagePhones.Entities.Entidades
{
    public class Marca : Entity
    {
        #region Properties
        public string Name { get; set; }
        #endregion

        #region Override
        // Override para mostrar el nombre en el ComboBox //
        public override string ToString()
        {
            return this.Name;
        }

        // Override para poder setear un item en ComboBox //
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }

            Marca m = (Marca)obj;
            return (this.Id == m.Id);
        }
        #endregion
    }
}
