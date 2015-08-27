using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MunicipalidaddelaCalera.Models
{
    public class Catergory
    {
        public Catergory()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}