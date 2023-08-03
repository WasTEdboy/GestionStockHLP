using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Location")]
public partial class Location
{
    [Key]
    public int LocationId { get; set; }

    public int IdMagasinier { get; set; }

    public int IdMagazin { get; set; }

    public int IdEmplacement { get; set; }

    public int IdInventaire { get; set; }

    [StringLength(50)]
    public string CodeArticle { get; set; } = null!;

    public int Quantity { get; set; }

    [Column("US")]
    [StringLength(50)]
    public string Us { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    [ForeignKey("CodeArticle")]
    [InverseProperty("Locations")]
    public virtual Stock CodeArticleNavigation { get; set; } = null!;

    [ForeignKey("IdEmplacement")]
    [InverseProperty("Locations")]
    public virtual Emplacement IdEmplacementNavigation { get; set; } = null!;

    [ForeignKey("IdInventaire")]
    [InverseProperty("Locations")]
    public virtual Inventaire IdInventaireNavigation { get; set; } = null!;

    [ForeignKey("IdMagasinier")]
    [InverseProperty("Locations")]
    public virtual Magasinier IdMagasinierNavigation { get; set; } = null!;

    [ForeignKey("IdMagazin")]
    [InverseProperty("Locations")]
    public virtual Magasin IdMagazinNavigation { get; set; } = null!;
}
