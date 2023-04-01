using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class SinhVien
    {
        private string ma_sv, ten, que_quan;
        public int tuoi;
        public string Que_quan { get => que_quan; set => que_quan = value; }
        public SinhVien()
        {
            ma_sv = "123";
            ten = "Q";
            Que_quan = "A";
            tuoi = 34;
        }
        public void di_hoc()
        {
            Console.WriteLine(ten+" hc bai");
        }
        static void Main()
        {
            SinhVien a = new SinhVien(); //cap phat bo nho cho class
            a.di_hoc();
        }
    }
}
