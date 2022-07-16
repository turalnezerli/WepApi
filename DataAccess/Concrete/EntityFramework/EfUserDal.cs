using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NortwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new NortwindContext())
            {
                var result = from opeClaim in context.OperationClaims
                             join userOpe in context.UserOperationClaims
on opeClaim.Id equals userOpe.OperationClaimId
                             where userOpe.UserId == user.Id
                             select new OperationClaim { Id = opeClaim.Id, Name = opeClaim.Name };
                return result.ToList();
            }
        }
    }
}
