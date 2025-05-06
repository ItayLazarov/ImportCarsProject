namespace ImportCarsWinForm.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public DateTime? FeedbackDate { get; set; }

    public string? FeedbackType { get; set; }

    public string? Comment { get; set; }
}
