
namespace GeneralDAL.Service
{
    using GeneralDAL.Common;
    using GeneralDAL.DataAccess;

    public static class ProductDTOExtension
    {
        internal static ProductDTO Map(this Product product, ProductDTO dto = null)
        {
            dto = dto ?? new ProductDTO();

            dto.Id = product.Id;
            dto.Name = product.Name;

            return dto;
        }

        internal static Product Map(this ProductDTO dto, Product product = null)
        {
            product = product ?? new Product();

            product.Id = dto.Id;
            product.Name = dto.Name;

            return product;
        }
    }
}
