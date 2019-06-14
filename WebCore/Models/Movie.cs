using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNo { get; set; }
        public string Country { get; set; }
        [NotMapped]
        public List<SelectListItem> countries { get; } = new List<SelectListItem>
        {
            new SelectListItem{Text="美国",Value="US",Selected = true},
            new SelectListItem{Text="英国",Value="EN"},
            new SelectListItem{Text="中国",Value="CH"},
            new SelectListItem{Text="法国",Value="FR"},
            new SelectListItem{Text="日本",Value="JA"},
            new SelectListItem{Text="俄国",Value="RU"}
        };
    }
}
