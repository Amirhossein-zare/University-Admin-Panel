using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Student : Parent
    {
        /// <summary>
        /// آیدی دانشجو
        /// </summary>
        public int StudentId { get; set; }
        /// <summary>
        /// آیدی ثبت شده از آخرین دانشجو
        /// </summary>
        public static int Id { get; set; } = 0;
        /// <summary>
        /// لیست انتخاب واحد های دانشجو
        /// </summary>
        public List<Course> studentCourseList = new List<Course>();

        /// <summary>
        /// متد سازنده دانشجو و استفاده از پراپرتی های متد کلاس مادر
        /// </summary>
        /// <param name="StudentId">آیدی دانشجو</param>
        /// <param name="Name">نام دانشجو</param>
        /// <param name="Family">نام خانوادگی دانشجو</param>
        /// <param name="PhoneNumber">تلفن همراه دانشجو</param>
        /// <param name="Age">سن دانشجو</param>
        /// <param name="City">محل سکونت دانشجو</param>
        public Student( string Name, string Family, string PhoneNumber, int Age, string City):base(Name,Family,PhoneNumber,Age,City)
        {
            Id++;
            this.StudentId = Id;
        }
        /// <summary>
        /// متد چاپ کلاس دانشجو و استفاده از متد چاپ مادر با کلمه بیس
        /// </summary>
        public override void Print()
        {
            Console.Write("S-Id: {0}   "
                ,StudentId);
            base.PrintParentInfo();
            Console.WriteLine("\n__________________________________________________________________________________________________________");
        }
        /// <summary>
        /// این متد وظیفه افزودن درس به لیست دانشجو را دارد
        /// </summary>
        /// <param name="courseItem">درس جدید برای دانشجو</param>
        public void AddCourseForStudent(Course courseItem)
        {
            studentCourseList.Add(courseItem);
        }
    }
}
