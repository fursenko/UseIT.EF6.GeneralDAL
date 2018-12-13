
namespace GeneralDAL.Service
{
    using GeneralDAL.Common;
    using GeneralDAL.DataAccess;
    using System;
    using System.Collections.Generic;

    public class ProductDataService
    {
        string _connectionString;

        public ProductDataService(string connectionString = null)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            using (var model = GetModel())
            {
                if (model.Products == null)
                    yield return null;

                foreach (var product in model.Products)
                    yield return product.Map();
            }
        }

        public void Add(ProductDTO dto)
        {
            using (var model = GetModel())
            {
                if (dto == null) throw new ArgumentNullException("dto");

                model.Products.Add(dto.Map());

                model.SaveChanges();
            }
        }

        protected virtual ProductModel GetModel()
        {
            if (String.IsNullOrWhiteSpace(_connectionString)) return new ProductModel();
            return new ProductModel(_connectionString);
        }

    }
}
