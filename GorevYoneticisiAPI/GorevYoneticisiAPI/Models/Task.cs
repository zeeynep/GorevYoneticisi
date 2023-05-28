using System.ComponentModel.DataAnnotations;

namespace GorevYoneticisiAPI.Models
{
    public class Task:BaseEntity
    {
        [Required(ErrorMessage = "Lütfen Başlık Alanını Doldurunuz.")]
        public string Header { get; set; }

        [Required(ErrorMessage = "Lütfen İçerik Alanını Doldurunuz.")]
        public string Body { get; set; }

    }
}
