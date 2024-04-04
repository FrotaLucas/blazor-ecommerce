﻿namespace BlazorEcommerce.Server.Services.CategoryService
{
    //Funcionaria se usassemo na interface ICategoryService :CategoryServic ????
    public class CategoryService : ICategoryService
    {
        readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context; 
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>()
            {
                Data = categories
            };
        }
        
    }

}
