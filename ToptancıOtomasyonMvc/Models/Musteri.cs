using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToptancıOtomasyonMvc.Models
{
    public class Musteri
    {
        public int Musteri_ID { get; set; }

        [Display(Name = "Müşteri Adı")]
        [Required(ErrorMessage = "Müşteri Adı Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string AD { get; set; }

        [Display(Name = "Müşteri Soyadı")]
        [Required(ErrorMessage = "Müşteri Soyadı Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string SOYAD { get; set; }

        [Display(Name = "Müşteri Telefonu")]
        [Required(ErrorMessage = "Müşteri Telefonu Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string Telefon { get; set; }

        [Display(Name = "Müşteri Şifresi")]
        [Required(ErrorMessage = "Şifre Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string Sifre { get; set; }

        [Display(Name = "Müşteri Tc No")]
        [Required(ErrorMessage = "Tc No Giriniz", AllowEmptyStrings = false)] //Gerekli
        public string TCKNo { get; set; }

    }
}