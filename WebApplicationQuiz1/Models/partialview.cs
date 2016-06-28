using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationQuiz1.Models
{
    public partial class partialview
    { //set y gets de la clase proyectos
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }
    }
    public partial class partialview
    {
        public List<partialview> partialModel { get; set; }

    }
}