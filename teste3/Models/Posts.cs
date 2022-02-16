using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste3.Models
{
    public class Posts
    {
        [Key]
        public long PostID { get; set; }
        public string TituloPost { get; set; }
        public string ResumoPost { get; set; }
        public string ConteudoPost { get; set; }
        public DateTime DataPostagem { get; set; }
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public virtual Categorias Categorias
        {
            get; set;
        }
    }
}