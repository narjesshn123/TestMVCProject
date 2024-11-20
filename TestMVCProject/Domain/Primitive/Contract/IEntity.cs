namespace MinimalProject.Catalog.Domain.Primitive.Contract
{
    public interface TEntity<TId> where TId : notnull     
    {
       TId Id { get; } 
    }
}
