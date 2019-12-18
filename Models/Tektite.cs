namespace eternalminerals.Models
{
  public class Tektite
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string DefaultColor { get; set; }

    public double? Hardness { get; set; }

    public bool IsRare { get; set; } = true;

  }


}