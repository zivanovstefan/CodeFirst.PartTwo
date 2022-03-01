using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DateOnly Year { get; set; }
        public int ChassisNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
    }
}
