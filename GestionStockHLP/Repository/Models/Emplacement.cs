using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Emplacement")]
public partial class Emplacement
{
    [Key]
    public int IdEmplacement { get; set; }

    [StringLength(50)]
    public string Nom { get; set; } = null!;

    public int? IdMagasin { get; set; }

    [ForeignKey("IdMagasin")]
    [InverseProperty("Emplacements")]
    public virtual Magasin? IdMagasinNavigation { get; set; }
    
    [InverseProperty("IdEmplacementNavigation")]
    [JsonIgnore]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
