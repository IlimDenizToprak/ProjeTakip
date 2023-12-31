﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Projem.Models.ProjeTakip;

namespace Projem.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }

        [Key] // Primary Key Olarak Görebiliriz
        public int PersonelBilgileriId { get; set; }

        [DisplayName("E-POSTA")] // İsimlendirmeler Yapıldı
        public string Eposta { get; set; }

        [DisplayName("ŞİFRE")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string Sifre { get; set; }

        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maksimum Uzunluk 15 Karakterden Fazla Olamaz")]
        public string Yetki { get; set; }

        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maksimum Uzunluk 50 Karakterden Fazla Olamaz")]
        public string AdSoyad { get; set; }

        [DisplayName("PERSONEL GÖRSELİ")]
        public string PersonelGorseli { get; set; }

        [DisplayName("TC KİMLİK NO")]
        [StringLength(15, ErrorMessage = "Maksimum Uzunluk 15 Karakterden Fazla Olamaz")]
        public string TCNO { get; set; }

        [DisplayName("DEPARTMANI")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string Departman { get; set; }

        [DisplayName("GÖREVİ")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string Gorev { get; set; }

        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }

        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maksimum Uzunluk 15 Karakterden Fazla Olamaz")]
        public string TelNo { get; set; }

        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }

        [DisplayName("MEDENİ HAL")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string MedeniHal { get; set; }

        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string YakinBilgisi { get; set; }

        [DisplayName("YAKIN TC NO")]
        [StringLength(15, ErrorMessage = "Maksimum Uzunluk 15 Karakterden Fazla Olamaz")]
        public string YakinTC { get; set; }

        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maksimum Uzunluk 25 Karakterden Fazla Olamaz")]
        public string YakinAdSoyad { get; set; }

        [DisplayName("YAKIN TELEFONU")]
        [StringLength(15, ErrorMessage = "Maksimum Uzunluk 15 Karakterden Fazla Olamaz")]
        public string YakinTel { get; set; }

        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }

        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }

    }
}