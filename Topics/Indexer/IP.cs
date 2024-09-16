using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IP
    {
        private int[] segements = new int[4];

        public IP(string ip) { 
            string[] segs=ip.Split(".");
            for (int i = 0; i < segs?.Length; i++)
            {
                segements[i] = int.Parse(segs[i]);
            }

        }
        public IP(int seg1,int seg2,int seg3,int seg4) {
            segements[0] = seg1;
            segements[1] = seg2;
            segements[2] = seg3;
            segements[3] = seg4;
        }
        public int this[int index]
        {
            get { return segements[index]; }
            set { segements[index] = value; }
        }
        public string Address=>string.Join(".", segements);
    }
}
