﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
   public class UserOperationClaim:IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OperationClaimId { get; set; }
        //public virtual User UserId { get; set; }
        //public virtual OperationClaim OperationClaimId { get; set; }
    }
}
