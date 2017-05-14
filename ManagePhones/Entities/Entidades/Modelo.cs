
namespace ManagePhones.Entities.Entidades
{
    public class Modelo : Entity
    {
        #region Properties
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        #endregion
    }
}
