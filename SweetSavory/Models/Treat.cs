using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatSweet>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryItem> JoinEntities { get; set; }
  }
}