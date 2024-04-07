﻿namespace BlazorEcommerce.Client.Services
{
    public interface IProductService
    {
        //pq essa propriedade aqui dentro da interface ????? Ele esta sendo preenchido
        //atraves do metodo GetProduct no arquivo ProductService. Mas como isso ?
        List<Product> Products {get; set;}

        //pq essse Task nao tem List ou ServiceResponse com encapsulamento ??????????
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
        //evento criado para ajudar a perceber mudanca quando categoria mudar. Depois do componente NavMenu inicializado
        //ele nao recarrega novamente
        event Action ProductsChanged;

        Task UpdateDate();

        DateTime MyDate { get; set;}    
    }
}
