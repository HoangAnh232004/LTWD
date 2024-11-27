using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTWD
{
   
    internal class Nv
    {
        public String MSNV { get; set; }
        public String TenNV { get; set; }
        public decimal LuongCB { get; set; }
        public Nv(String mSNV, string tenNV, decimal luongCB)
        {
            MSNV = mSNV;
            TenNV = tenNV;
            LuongCB = luongCB;
        }

    }
}
