using Alphastellar.Case.CoreLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Case.CoreLayer.Entities
{
    public class Car: Vehicle
    {
        public int? Wheels { get; set; } = 4;
        public bool Headlights { get; set; }

        public class Light
        {
            public bool onOff { get; set; }
        }
    }

}
