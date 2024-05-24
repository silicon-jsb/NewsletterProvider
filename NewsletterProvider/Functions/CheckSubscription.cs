using Data.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace NewsletterProvider.Functions;

public class CheckSubscription(ILogger<Subscribe> logger, DataContext context)
{
    private readonly ILogger<Subscribe> _logger = logger;
    private readonly DataContext _context = context;


    [Function("CheckSubscription")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        try
        {
            var email = req.Query["email"].ToString();
            if (!string.IsNullOrEmpty(email))
            {
                var existingSubscriber = await _context.SubscribeEntities.FirstOrDefaultAsync(s => s.Email == email);
                return new OkObjectResult(new { Status = 200, Subscribed = existingSubscriber != null });
            }
            else
            {
                return new BadRequestObjectResult(new { Status = 400, Message = "Email is required." });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"CheckSubscription.Run() :: {ex.Message}");
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}
