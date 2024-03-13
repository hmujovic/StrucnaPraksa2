using API.Database;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Services.CategoryService
{
    public class CategoryService(DataContext context) : ICategoryService
    {
        public async Task CreateCategory(Category category)
        {
            context.Categories.Add(category);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null)
            {
                return;
            }

            context.Categories.Remove(category);
            await context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetCategories()
        {
            var categories = await context.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            return category;
        }

        public async Task UpdateCategory(int categoryId, Category category)
        {
            var categoryCheck = await context.Categories.FindAsync(categoryId);
            if (categoryCheck == null)
            {
                return;
            }

            context.Update(category);
            await context.SaveChangesAsync();
        }
    }
}
