using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace NewsletterProvider.Functions
{
    public class Subscribe(ILogger<Subscribe> logger, DataContext context)
    {
        private readonly ILogger<Subscribe> _logger = logger;
        private readonly DataContext _context = context;

        //    [Function("Subscribe")]
        //    public async IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        //    {
        //        try
        //        {
        //            var body = await new StreamReader(req.Body).ReadToEndAsync();
        //            if (!string.IsNullOrEmpty(body))
        //            {
        //                var e
        //                var SubscribeEntity = JsonConvert.DeserializeObject<SubscribeEntity>(body);
        //                if (SubscribeEntity != null)
        //                {
        //                    _context.SubscribeEntities.Add(SubscribeEntity);
        //                    await _context.SaveChangesAsync();
        //                    return new OkResult();
        //                }
        //                else
        //                {
        //                    _logger.LogError($"Invalid request body");
        //                    return new BadRequestResult();

        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError($"Subscribe.Run() :: {ex.Message}");
        //        }
        //        return null!;
        //    }
    }
}
