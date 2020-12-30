using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Models
{
    public class ContactSectionModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string EmailForContact { get; set; }
        public string Phone { get; set; }
        public string FbUserName { get; set; }
        public string InstaUserName { get; set; }
        public string SectionName { get; set; }

        //messages

        [Display(Name = "Ad Soyad", Prompt = "Lütfen adınızı yazınız.")]
        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Adınız 5 ile 50 karakter arasında olmalıdır.")]
        public string Name { get; set; }


        [Display(Name = "Eposta", Prompt = "Örn: eposta@site.com")]
        [Required(ErrorMessage = "Eposta alanı zorunludur.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Epostanız 5 ile 50 karakter arasında olmalıdır.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen geçerli bir eposta giriniz.")]
        public string Email { get; set; }


        [Display(Name = "Başlık", Prompt = "Mesajınızın konusu nedir?")]
        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Başlık 5 ile 50 karakter arasında olmalıdır.")]
        public string Subject { get; set; }


        [Display(Name = "Mesaj", Prompt = "Bize ne iletmek istiyorsunuz?")]
        [Required(ErrorMessage = "Mesaj alanı zorunludur.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Mesajınız 10 ile 1000 karakter arasında olmalıdır.")]
        public string Text { get; set; }
    }
}
