using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Magasinier")]
public partial class Magasinier
{
    [Key]
    public int IdMagasinier { get; set; }

    [StringLength(20)]
    public string? MatMagasinier { get; set; }

    [StringLength(20)]
    public string? Password { get; set; }

    [InverseProperty("IdMagasinierNavigation")]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
