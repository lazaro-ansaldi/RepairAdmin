
namespace Entities.Entidades
{
    public class Modelo : IEntity
    {
        #region Properties
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }
        public Marca Marca { get; set; }
        #endregion
    }
}
