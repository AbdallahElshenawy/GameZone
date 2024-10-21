using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services;

public class CategoriesService : ICategoriesService
{
    private readonly GameZoneDbContext _context;

    public CategoriesService(GameZoneDbContext context)
    {
        _context = context;
    }

    public IEnumerable<SelectListItem> GetSelectList()
    {
        return _context.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()
                .ToList();
    }
}