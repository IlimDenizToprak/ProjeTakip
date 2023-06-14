using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projem.Models.Departman
{
    public class DepartmanBilgileri
    {
        [Key] // Primary Key Olarak Görebiliriz
        public int DepartmanBilgileriId { get; set; }

        [DisplayName("DEPARTMAN ADI")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string DepartmanAdi { get; set; }
    }
}