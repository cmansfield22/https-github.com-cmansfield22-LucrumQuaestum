using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LucrumQuaestum.Models
{
    public class AlpacaKeyModel
    {
        [Display(Name = "Live Api Key")]
        [Required]
        public string LiveApiKey { get; set; }
        [Display(Name = "Live Api Secret Key")]
        [Required]
        public string LiveApiSecretKey { get; set; }
        [Display(Name = "Paper Api Key")]
        [Required]
        public string PaperApiKey { get; set; }
        [Display(Name = "Paper Api Secret Key")]
        [Required]
        public string PaperApiSecretKey { get; set; }
    }
}