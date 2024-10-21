
using GameZone.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

public class DevicesService : IDevicesService
{
    private readonly GameZoneDbContext _context;

    public DevicesService(GameZoneDbContext context)
    {
        _context = context;
    }

    public IEnumerable<SelectListItem> GetSelectList()
    {
        return _context.Devices
                .Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
                .OrderBy(d => d.Text)
                .AsNoTracking()
                .ToList();
    }
}