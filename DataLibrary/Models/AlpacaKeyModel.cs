using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class AlpacaKeyModel
    {
        public string UserID { get; set; }
        public string LiveApiKey { get; set; }
        public string LiveApiSecretKey { get; set; }
        public string PaperApiKey { get; set; }
        public string PaperApiSecretKey { get; set; }
    }
}
