using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSis
{
   public class Test
    {
        public int[] baslikId = { 1, 2, 3, 4, 5 };
        public int[] basliklarinYanlisSayilari=new int[5];
        public DateTime sinavTarihi;
        public DateTime oncekiSinavTarihi;
        public int yanlisSayisi;
        public List<soru> sorular = new List<soru>();

    }
}
