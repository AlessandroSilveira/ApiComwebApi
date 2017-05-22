using System.Data.Entity.ModelConfiguration;
using DevStore.Domain;

namespace DevStore.Infra.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(a => a.Title).HasMaxLength(160).IsRequired();
            Property(a => a.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category);
        }
    }
}
