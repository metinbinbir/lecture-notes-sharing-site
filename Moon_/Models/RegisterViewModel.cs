﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Moon_.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter your surname.")]
        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Please enter your username.")]
        [Display(Name = "User name")]
        public string id { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string department { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{6,15}$", ErrorMessage = "The password must contains at least 1:alphanumeric uppercase numeric lowercase")]
        [Display(Name = "Password")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail address.")]
        [EmailAddress]
        //[RegularExpression("^(l[0-9]{7})@(std.yildiz.edu.tr)$", ErrorMessage = "Please enter your YTU email address.")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

    }
}
