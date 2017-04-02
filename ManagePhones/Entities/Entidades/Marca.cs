
namespace Entities.Entidades
{
    public class Marca:IEntity
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Override
        public override string ToString()
        {
            return this.Name;
        }
        #endregion
    }
}
