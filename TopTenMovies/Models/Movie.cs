using System.ComponentModel.DataAnnotations;

namespace TopTenMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Назва")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Режисер")]
        public string? Director { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Жанр")]
        public string? Genre { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Рік")]
        [Range(1910, 2024, ErrorMessage = "Недопустимий рік")]
        public int Year { get; set;}
        [Display(Name = "Постер")]
        public string? Poster { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Опис")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Країна")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Бюджет")]
        public string? Budget { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Збори")]
        public string? Box_Office { get; set; }
        [Required(ErrorMessage = "Поле має бути встановлено")]
        [Display(Name = "Тривалість")]
        public string? Duration { get; set; }
    }
}
