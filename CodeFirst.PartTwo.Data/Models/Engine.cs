using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Data.Models
{
    public class Engine
    {
        public int Id { get; set; }
        public DateOnly Year { get; set; }
        public string Brand { get; set; }
        public int SerialNumber { get; set; }
        public string Type { get; set; }
        public Car Car { get; set; }
        public EngineType EngineType { get; set; }

    }
}
