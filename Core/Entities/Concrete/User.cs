using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "Varbinary")]
        [StringLength(500)]
        public byte[] PasswordSalt { get; set; }
        [Column(TypeName = "Varbinary")]
        [StringLength(500)]
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
       // public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
