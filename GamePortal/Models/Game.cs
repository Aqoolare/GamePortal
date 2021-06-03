using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GamePortal.Models
{
    [Table("Books")]
    public class Game
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите название")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите рейтинг")]
        [Range(0, 10, ErrorMessage = "Недопустимое значение")]
        [Display(Name = "Рейтинг")]
        public double Score { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите разработчика")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Длина строки должна быть от 1 до 50 символов")]
        [Display(Name = "Разработчик")]
        public string Developer { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите издателя")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Длина строки должна быть от 1 до 50 символов")]
        [Display(Name = "Издатель")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите дату издания")]
        [Range(1700, 2021, ErrorMessage = "Недопустимый год")]
        [Display(Name = "Год издания")]
        public DateTime Release { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Пожалуйста введите жанр")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
    }
}
