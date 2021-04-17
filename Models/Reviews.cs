using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoWebTest.Models
{
    public class Reviews
    {

        public int Id { get; set; }
        public string Movie_Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        public string Data { get; set; }
        



    }
}
