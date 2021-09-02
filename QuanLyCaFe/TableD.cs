using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class TableD
    {
        private static TableD instance;

        public static TableD Instance { get { if (instance == null) instance = new TableD(); return TableD.instance; } 
            set => instance = value; }
    }
}
