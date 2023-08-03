using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Inventaire")]
public partial class Inventaire
{
    [Key]
    public int IdInventaire { get; set; }

    [StringLength(50)]
    public string MariculeInventaire { get; set; } = null!;

    [InverseProperty("IdInventaireNavigation")]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
