using API.Entities;

namespace API.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryById(int id);
        Task CreateCategory(Category category);
        Task UpdateCategory(int categoryId, Category category);
        Task DeleteCategory(int id);
    }
}
