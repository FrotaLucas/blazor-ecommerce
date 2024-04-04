namespace BlazorEcommerce.Client.Services
{
    public interface IProductService
    {
        //pq essa propriedade aqui dentro da interface ????? Ele esta sendo preenchido
        //atraves do metodo GetProduct no arquivo ProductService. Mas como isso ?
        List<Product> Products {get; set;}

        //pq essse Task nao tem List ou ServiceResponse com encapsulamento ??????????
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
