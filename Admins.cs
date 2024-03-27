using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Admins:Parent
    {
        /// <summary>
        /// آیدی ادمین
        /// </summary>
        public int AdminId { get; set; }
        /// <summary>
        /// آیدی ادمین ثبت شده
        /// </summary>
        public static int Id { get; set; } = 2000;
        /// <summary>
        /// یوزر نیم ادمین
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// پسوورد ادمین
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// متد سازنده ادمین و استفاده از پراپرتی های متد کلاس مادر
        /// </summary>
        /// <param name="Username">یوزرنیم</param>
        /// <param name="Password">پسوورد</param>
        /// <param name="Name">نام کاربری</param>
        /// <param name="Family">نام خانوادگی کاربر</param>
        /// <param name="PhoneNumber">تلفن همراه کاربر</param>
        /// <param name="Age">سن کاربر</param>
        /// <param name="City">محل سکونت کاربر</param>
        public Admins(string Username,string Password, string Name, string Family, string PhoneNumber, int Age, string City):base(Name,Family,PhoneNumber,Age,City)
        {
            Id++;
            this.AdminId = Id;
            this.Username = Username;
            this.Password = Password;
        }
        /// <summary>
        /// متد چاپ کلاس ادمین و استفاده از متد چاپ مادر با کلمه بیس 
        /// </summary>
        public override void Print()
        {
            Console.Write("A-Id: {0}   Username: {1}   Password: {2}"
                ,AdminId,Username,Password );
            base.PrintParentInfo();
            Console.WriteLine("\n__________________________________________________________________________________________________________");
        }
    }
}
