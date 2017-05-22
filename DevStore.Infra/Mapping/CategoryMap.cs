using System.Data.Entity.ModelConfiguration;
using DevStore.Domain;

namespace DevStore.Infra.Mapping
{
   public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(a => a.Id);
            Property(x => x.Title).HasMaxLength(60).IsRequired();
        }
    }
}
