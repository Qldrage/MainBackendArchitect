using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfUserDal:EfEntityRepositoryBase<User,TrainingContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new TrainingContext())
            {

                var result = from contextOperationClaim in context.OperationClaims

                    join contextUserOperationClaim in context.UserOperationClaims on contextOperationClaim.Id equals

                        contextUserOperationClaim.OperationClaimId

                    where contextUserOperationClaim.UserId == user.Id

                    select new OperationClaim {Id = contextOperationClaim.Id, Name = contextOperationClaim.Name};

                return result.ToList();
            }
            
        }
    }
}
