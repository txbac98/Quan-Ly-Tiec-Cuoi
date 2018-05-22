using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Ca
    {
        private string text1;
        private string text2;

        public DTO_Ca(string text1, string text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }
      
        public string MaCa { get; set; }
        public string TenCa { get; set; }
    }
   
}
