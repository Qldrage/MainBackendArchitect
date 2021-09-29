using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string CategoryName { get; set; }
    }
}
