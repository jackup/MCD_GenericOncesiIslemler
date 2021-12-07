using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_GenericOncesiIslemler
{
    public class VirtualDatabase
    {
        private ArrayList listem;

        public VirtualDatabase()
        {
            listem = new ArrayList();
        }
        public void YeniKayit(int data)
        {
            listem.Add(data);
        }
    }
}
