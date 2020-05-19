using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToptancıOtomasyonMvc.Models.ViewModels
{
    public class MusteriViewModel
    {
        public Musteri Mus { get; set; }
        public IEnumerable<Musteri> Musteriler { get; set; }
    }
}