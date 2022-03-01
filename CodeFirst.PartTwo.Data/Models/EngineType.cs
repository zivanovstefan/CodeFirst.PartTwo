using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Data.Models
{
    public class EngineType
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public List<Engine> Engines { get; set; }
    }
}
