using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Projem.Models.Personel;

namespace Projem.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri()
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }

        [Key]
        public int PersonelProjeId { get; set; }

        [DisplayName("PROJE BAŞLIĞI")]
        [StringLength(150, ErrorMessage = "Maksimum Uzunluk 150 Karakterden Fazla Olamaz")]
        public string ProjeBaslik { get; set; }
        public string ProjeAciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        [DisplayName("ÖNCELİK DURUMU")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25S Karakterden Fazla Olamaz")]
        public string OncelikDurumu { get; set; }
        public int TamamlanmaOrani { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public bool TamamlanmaDurumu { get; set; }
        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }
    }
}