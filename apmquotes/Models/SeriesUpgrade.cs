using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ApmQuotes.Models
{
    public enum SeriesUpgrade
    {
        [Display(Name = "Series One")]
        SeriesOne = 1,
        [Display(Name = "Series Two")]
        SeriesTwo = 2,
        [Display(Name = "Series Three")]
        SeriesThree = 3,
        [Display(Name = "Series Four")]
        SeriesFour = 4

    }
}
