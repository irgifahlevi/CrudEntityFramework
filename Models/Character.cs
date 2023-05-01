using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitsPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelegence { get; set; } = 10;
    }
}