using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobAllyWebApp.Pages;

public class SubscribeModel : PageModel
{
    private readonly ILogger<SubscribeModel> _logger;

    public SubscribeModel(ILogger<SubscribeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}