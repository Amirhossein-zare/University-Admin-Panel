using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Employee : Parent
    {
        /// <summary>
        /// آیدی کارکنان
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// آیدی ثبت شده اخرین کارمند
        /// </summary>
        public static int Id { get; set; } = 200;
        /// <summary>
        /// متد سازنده کارکنان و استفاده از پراپرتی های متد کلاس مادر
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Family"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="Age"></param>
        /// <param name="City"></param>
        public Employee(string Name, string Family, string PhoneNumber, int Age, string City):base(Name,Family,PhoneNumber,Age,City)
        {
            Id++;
            this.EmployeeId = Id;
        }
        /// <summary>
        /// متد چاپ کلاس کارکنان و استفاده از متد چاپ مادر با کلمه بیس
        /// </summary>
        public override void Print()
        {
            Console.Write("E-Id: {0}   "
                , EmployeeId);
            base.PrintParentInfo();
            Console.WriteLine("\n__________________________________________________________________________________________________________");
        }
    }
}
