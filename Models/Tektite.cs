
namespace eternalminerals.Models

{
  public class Tektite

  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string DefaultColor { get; set; }

    public double? Hardness { get; set; } //can we set to 0

    public bool IsRare { get; set; } = true;

    public string Sku { get; set; }

    public string Bio { get; set; }

    public int Quantity { get; set; }

    public double? Price { get; set; }

    public bool Stocked { get; set; } = true;

  }


}