using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Schools
{
   public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Code{ get; set; }
        public string Description { get; set; }
        public string  SubjectClassName { get; set; }
        public string Color { get; set; }
        public string ConvertedColor { get; set; }
        public DateTime PedagogicDate { get; set; }

    }
}
