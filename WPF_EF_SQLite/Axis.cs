using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_SQLite
{
    [Table("Axis")]
    class Axis
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Position { get; set; }
    }
}
