
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Master:Parent
    {
        /// <summary>
        /// آیدی استاد
        /// </summary>
        public int MasterId { get; set; }
        /// <summary>
        /// آیدی ثبت شده از آخرین استاد
        /// </summary>
        public static int Id { get; set; } = 100;
        /// <summary>
        /// متد سازنده استاد و استفاده از پراپرتی های متد کلاس مادر
        /// </summary>
        /// <param name="Name">نام استاد</param>
        /// <param name="Family">نام خانوادگی استاد</param>
        /// <param name="PhoneNumber">تلفن همراه استاد</param>
        /// <param name="Age">سن استاد</param>
        /// <param name="City">محل سکونت استاد</param>
        public Master(string Name, string Family, string PhoneNumber, int Age, string City):base(Name,Family,PhoneNumber,Age,City)
        {
            Id++;
            this.MasterId = Id;
        }
        /// <summary>
        /// متد چاپ کلاس استاد و استفاده از متد چاپ مادر با کلمه بیس
        /// </summary>
        public override void Print()
        {
            Console.Write("M-Id: {0}   "
                , MasterId);
            base.PrintParentInfo();
            Console.WriteLine("\n__________________________________________________________________________________________________________");
        }
    }
}
