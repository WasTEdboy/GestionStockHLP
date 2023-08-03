using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GestionStockHLP.Repository.Models
{
    public class Locationfinder
    {
        [Key]
        public string? Us { get; set; } 
        public string? CodeArticle { get; set; } 
        public string? MatMagasinier { get; set; }
        public string? Nom { get; set; } 
        public string? MariculeInventaire { get; set; } 


    }
}
