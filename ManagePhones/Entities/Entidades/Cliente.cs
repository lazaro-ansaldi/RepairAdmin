
namespace Entities.Entidades
{
    public class Cliente : IEntity
    {
        #region Properties
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }
        #endregion

    }
}
