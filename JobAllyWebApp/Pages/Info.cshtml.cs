using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobAllyWebApp.Pages;

public class InfoModel : PageModel
{
    private readonly ILogger<InfoModel> _logger;

    public InfoModel(ILogger<InfoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}