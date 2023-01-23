using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Case.CoreLayer.Entities.Abstract
{
    public abstract class Vehicle : IBaseEntity
    {
        public Vehicle()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get ;set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
