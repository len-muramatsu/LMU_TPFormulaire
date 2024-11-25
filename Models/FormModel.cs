using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Entrez un nom.")]
        public string? Name { get; set; }

        [StringLength(60, ErrorMessage = "Le nombre de caractères maximal est de {0}.")]
        [Required(ErrorMessage = "Entrez un prénom.")]
        public string? Forename { get; set; }

        [Required(ErrorMessage = "Choisissez un genre.")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Entrez une adresse.")]
        public string? Address { get; set; }

        [RegularExpression(@"\d{5}", ErrorMessage = "Le code postal doit être composé de 5 chiffres.")]
        public int? ZipCode { get; set; }

        [Required(ErrorMessage = "Entrez une ville.")]
        public string? Town { get; set; }

        [Required(ErrorMessage = "Entrez une adresse email.")]
        [EmailAddress(ErrorMessage = "Le format de l'adresse email n'est pas correct.")]
        public string? EmailAdress { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(@"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19[5-9][0-9]|20[0-2][0-1]|2021)")]
        public DateTime DateDebutFormation { get; set; }

        [Required(ErrorMessage = "Chhoisissez une formation.")]
        public string? Formation { get; set; }

        [Required(ErrorMessage = "Entrez un avis.")]
        public string? AvisFormationCobol { get; set; }

        [Required(ErrorMessage = "Entrez un avis.")]
        public string? AvisFormationCs { get; set; }
    }
}
