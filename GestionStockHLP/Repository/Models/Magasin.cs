using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Magasin")]
public partial class Magasin
{
    [Key]
    public int IdMagasin { get; set; }

    [StringLength(50)]
    public string Nom { get; set; } = null!;

    [InverseProperty("IdMagasinNavigation")]
    [JsonIgnore]
    public virtual ICollection<Emplacement> Emplacements { get; set; } = new List<Emplacement>();

    [InverseProperty("IdMagazinNavigation")]
    [JsonIgnore]

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
