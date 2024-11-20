namespace MinimalProject.Catalog.Domain.Primitive.Contract
{
    public abstract class Entity<TId> : TEntity<TId>        
        where TId : notnull       
    {
        public TId Id { get; private set;  }
        public Entity(TId id)
        {
            Id = id;    
        }
    }
   
}
