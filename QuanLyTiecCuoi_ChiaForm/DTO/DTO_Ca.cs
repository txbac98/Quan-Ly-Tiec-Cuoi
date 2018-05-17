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

        public DTO_Ca(decimal v, string text)
        {
            this.v = v;
            this.text = text;
        }

        public DTO_Ca(string text, decimal v)
        {
            this.text = text;
            this.v = v;
        }
        public DTO_Ca()
        {
           
        }
        public int MaCa;
        private decimal v;
        private string text;

        public string TenCa { get; set; }
    }
}

