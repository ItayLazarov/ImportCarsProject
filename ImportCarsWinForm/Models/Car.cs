namespace ImportCarsWinForm.Models;

public partial class Car
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? CarNumber { get; set; }

    public string? Model { get; set; }

    public string? Color { get; set; }
}
