using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Repository.Models;

[Table("Stock")]
public partial class Stock
{
    [Column("US")]
    [StringLength(50)]
    public string Us { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string CodeArticle { get; set; } = null!;

    public int Quantity { get; set; }

    [InverseProperty("CodeArticleNavigation")]
    public virtual ICollection<Location> Locations { get;  } = new List<Location>();
}
