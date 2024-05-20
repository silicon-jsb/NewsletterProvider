using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class SubscribeEntity
{
    [Key]
    public string Email { get; set; } = null!;
    public bool DailyNewsletter { get; set; } = true;
    public bool EventUpdates { get; set; } = true;
    public bool AdvertisingUpdates { get; set; } = true;
    public bool StartupsWeekly { get; set; } = true;
    public bool WeekInReview { get; set; } = true;
    public bool Podcasts { get; set; } = true;
}
