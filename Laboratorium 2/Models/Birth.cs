using System.ComponentModel.DataAnnotations;

namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string imie { get; set; }
        public DateTime data_urodzenia { get; set; }

        public bool IsValid()
        {
            return imie != null && data_urodzenia<DateTime.Now ;
        }
        public int wiek()
        {
            return (DateTime.Now.Year-data_urodzenia.Year);
        }
    }
}
