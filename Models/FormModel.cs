using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        //public int Id { get; set; }

        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Entrez un nom.")]
        public string? Name { get; set; }

        [StringLength(60, ErrorMessage = "Le nombre de caractères maximal est de {0}.")]
        [Required(ErrorMessage = "Entrez un prénom.")]
        [Display(Name = "Prénom")]
        public string? Forename { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Choisissez un genre.")]
        public string? Gender { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Entrez une adresse.")]
        public string? Address { get; set; }

        [Display(Name = "Code Postal")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Le code postal doit être composé de 5 chiffres.")]
        public int? ZipCode { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Entrez une ville.")]
        public string? Town { get; set; }

        [Display(Name = "Adresse mail")]
        [Required(ErrorMessage = "Entrez une adresse email.")]
        [EmailAddress]
        public string? EmailAdress { get; set; }

        [Display(Name = "Date début formation")]
        [Required]
        [DataType(DataType.Date)]        
        public DateTime DateDebutFormation { get; set; }
   
        [Display(Name = "Formation suivie")]
        [Required(ErrorMessage = "Choisissez une formation.")]
        public string? FormationSuivie { get; set; }

        [Display(Name = "Formation Cobol")]        
        public string? AvisFormationCobol { get; set; }

        [Display(Name = "Formation C#")]       
        public string? AvisFormationCs { get; set; }
    }
}
