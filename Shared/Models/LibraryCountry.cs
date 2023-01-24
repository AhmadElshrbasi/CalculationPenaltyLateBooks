using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTouchTask.Shared.Models
{
    public class LibraryCountry
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrencyKey { get; set; }
        public float PenaltyValueOneDay { get; set; }

    }
}
