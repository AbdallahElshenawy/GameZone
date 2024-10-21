using GameZone.Attributes;
using GameZone.Settings;

namespace GameZone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(fileSettings.AllowedExtensions),
            MaxFileSize(fileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
