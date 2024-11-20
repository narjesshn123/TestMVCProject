using MinimalProject.Catalog.Domain.Primitive.Contract;

namespace TestMVCProject.Domain.Product
{
        public class Product : Entity<int>
        {
            public Product(int id) : base(id)
            {

            }
  

        public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
   
}
