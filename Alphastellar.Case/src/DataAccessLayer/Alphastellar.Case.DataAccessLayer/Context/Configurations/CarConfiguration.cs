using Alphastellar.Case.CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar.Case.DataAccessLayer.Context.Configirations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                 new Car
                 {
                     Id = 1,
                     Color = "Red",
                     Brand = "Brand1",
                     Model = "Model1",
                     Headlights = false,
                     Wheels = 4,
                     CreatedDate = DateTime.Now
                 },
                   new Car
                   {
                       Id = 2,
                       Color = "Red",
                       Brand = "Brand2",
                       Model = "Model2",
                       Headlights = false,
                       Wheels = 4,
                       CreatedDate = DateTime.Now
                   },
                     new Car
                     {
                         Id = 3,
                         Color = "Blue",
                         Brand = "Brand3",
                         Model = "Model3",
                         Headlights = false,
                         Wheels = 4,
                         CreatedDate = DateTime.Now
                     },
                       new Car
                       {
                           Id = 4,
                           Color = "Blue",
                           Brand = "Brand4",
                           Model = "Model4",
                           Headlights = false,
                           Wheels = 4,
                           CreatedDate = DateTime.Now
                       },
                         new Car
                         {
                             Id = 5,
                             Color = "Blue",
                             Brand = "Brand1",
                             Model = "Model1",
                             Headlights = false,
                             Wheels = 4,
                             CreatedDate = DateTime.Now
                         },
                           new Car
                           {
                               Id = 6,
                               Color = "Black",
                               Brand = "Brand1",
                               Model = "Model1",
                               Headlights = false,
                               Wheels = 4,
                               CreatedDate = DateTime.Now
                           },
                             new Car
                             {
                                 Id = 7,
                                 Color = "White",
                                 Brand = "Brand1",
                                 Model = "Model1",
                                 Headlights = false,
                                 Wheels = 4,
                                 CreatedDate = DateTime.Now
                             },
                               new Car
                               {
                                   Id = 8,
                                   Color = "White",
                                   Brand = "Brand1",
                                   Model = "Model1",
                                   Headlights = false,
                                   Wheels = 4,
                                   CreatedDate = DateTime.Now
                               }
                               );
        }
    }
}
