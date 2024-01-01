﻿using System.ComponentModel.DataAnnotations;

namespace VacationTrip.Models.Siniflar
{
    public class İletisim
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}
