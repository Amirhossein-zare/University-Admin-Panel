using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    abstract class Parent
    {
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام خانوادگی کاربر
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// شماره تلفن کاربر
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// سن کاربر
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// محل شهر سکونت کاربر
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// متد سازنده اشیا مشترک بین متد های تعریف شده
        /// </summary>
        /// <param name="Name">نام کاربر</param>
        /// <param name="Family">نام خانوادگی کاربر</param>
        /// <param name="PhoneNumber">شماره تلفن کاربر</param>
        /// <param name="Age"> سن کاربر</param>
        /// <param name="City">محل سکونت کاربر</param>
        public Parent(string Name, string Family, string PhoneNumber, int Age, string City)
        {
            this.Name = Name;
            this.Family = Family;
            this.PhoneNumber = PhoneNumber;
            this.Age = Age;
            this.City = City;
        }
        /// <summary>
        /// متد چاپ برای اشیا مشترک
        /// </summary>
        public void PrintParentInfo()
        {
            Console.Write("Name: {0}   Family: {1}   PhoneNumber: {2}   Age: {3}   City: {4}"
                ,Name,Family,PhoneNumber,Age,City);
        }
        /// <summary>
        /// متد الزامی برای چاپ تمامی متد های تعریف شده
        /// </summary>
        public abstract void Print();
    }
}
