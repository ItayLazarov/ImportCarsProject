namespace ImportCarsWinForm.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyHp { get; set; }

    public DateTime? Date { get; set; }

    public string? Comment { get; set; }
}
