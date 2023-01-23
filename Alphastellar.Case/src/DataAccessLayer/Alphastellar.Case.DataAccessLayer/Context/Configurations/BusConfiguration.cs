using Alphastellar.Case.CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar.Case.DataAccessLayer.Context.Configurations
{
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                new Bus
                {
                    Id = 1,
                    Color = "Red",
                    Brand = "Brand1",
                    Capacity = 100,
                    Model = "Model1",
                    CreatedDate = DateTime.Now,
                },
                  new Bus
                  {
                      Id = 2,
                      Color = "Red",
                      Brand = "Brand2",
                      Capacity = 100,
                      Model = "Model2",
                      CreatedDate = DateTime.Now,
                  },
                    new Bus
                    {
                        Id = 3,
                        Color = "Blue",
                        Brand = "Brand3",
                        Capacity = 100,
                        Model = "Model3",
                        CreatedDate = DateTime.Now,
                    },
                      new Bus
                      {
                          Id = 4,
                          Color = "Red",
                          Brand = "Brand4",
                          Capacity = 100,
                          Model = "Model4",
                          CreatedDate = DateTime.Now,
                      },
                        new Bus
                        {
                            Id = 5,
                            Color = "White",
                            Brand = "Brand5",
                            Capacity = 100,
                            Model = "Model5",
                            CreatedDate = DateTime.Now,
                        },
                          new Bus
                          {
                              Id = 6,
                              Color = "Blue",
                              Brand = "Brand6",
                              Capacity = 100,
                              Model = "Model6",
                              CreatedDate = DateTime.Now,
                          },
                            new Bus
                            {
                                Id = 7,
                                Color = "Black",
                                Brand = "Brand7",
                                Capacity = 100,
                                Model = "Model7",
                                CreatedDate = DateTime.Now,
                            }
                );
        }
    }
}
