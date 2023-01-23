using Alphastellar.Case.CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alphastellar.Case.DataAccessLayer.Context.Configurations
{
    public class BoatConfiguration : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
                new Boat
                {
                    Id = 1,
                    Color = "Blue",
                    Name = "Name1",
                    Brand = "Brand1",
                    Lenght = 100,
                    Model = "Model1",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 2,
                    Color = "Blue",
                    Name = "Name2",
                    Brand = "Brand2",
                    Lenght = 100,
                    Model = "Model2",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 3,
                    Color = "Blue",
                    Name = "Name3",
                    Brand = "Brand3",
                    Lenght = 100,
                    Model = "Model3",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 4,
                    Color = "Red",
                    Name = "Name4",
                    Brand = "Brand4",
                    Lenght = 100,
                    Model = "Model4",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 5,
                    Color = "Blue",
                    Name = "Name1",
                    Brand = "Brand1",
                    Lenght = 100,
                    Model = "Model1",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 6,
                    Color = "White",
                    Name = "Name1",
                    Brand = "Brand1",
                    Lenght = 100,
                    Model = "Model1",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 7,
                    Color = "Red",
                    Name = "Name1",
                    Brand = "Brand1",
                    Lenght = 100,
                    Model = "Model1",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 8,
                    Color = "Black",
                    Name = "Name8",
                    Brand = "Brand8",
                    Lenght = 100,
                    Model = "Model8",
                    CreatedDate = DateTime.Now
                },
                new Boat
                {
                    Id = 9,
                    Color = "White",
                    Name = "Name9",
                    Brand = "Brand9",
                    Lenght = 100,
                    Model = "Model9",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
