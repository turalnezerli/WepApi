using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        IResult TransactionOperation(Product product);
        





        //Product GetById(int productId );
        //List<Product> GetList();
        //List<Product> GetListByCategory(int categoryId);
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);


    }
}
