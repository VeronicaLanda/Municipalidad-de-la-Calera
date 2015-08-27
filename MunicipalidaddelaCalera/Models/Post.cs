using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MunicipalidaddelaCalera.Models
{
    public class Post
    {
        public Post()
        {
            Categories = new List<Catergory>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Context { get; set; }
                
        public virtual ApplicationUser User { get; set; }
        public virtual List<Catergory> Categories { get; set; }
    }
}