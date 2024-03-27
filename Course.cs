using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Course 
    {
        /// <summary>
        /// آیدی درس
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// آیدی آخرین درس ثبت شده
        /// </summary>
        public static int Id { get; set; } = 1000;
        /// <summary>
        /// نام درس
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// تعداد واحد درس
        /// </summary>
        public int CourseUnit { get; set; }
        /// <summary>
        /// نام استاد درس
        /// </summary>
        public string CourseMasterName { get; set; }
        /// <summary>
        /// متد سازنده کلاس واحد های درسی
        /// </summary>
        /// <param name="CourseName">نام درس</param>
        /// <param name="CourseUnit">تعداد واحد درس</param>
        /// <param name="CourseMasterName">نام استاد درس</param>
        public Course(string CourseName, int CourseUnit, string CourseMasterName)
        {
            Id++;
            this.CourseId = Id;
            this.CourseName = CourseName;
            this.CourseUnit = CourseUnit;
            this.CourseMasterName = CourseMasterName;
        }
        /// <summary>
        /// متد چاپ کلاس واحد های درسی
        /// </summary>
        public void Print()
        {
            Console.Write("C-Id: {0}   Name: {1}   Unit: {2}   Master: {3}"
                ,CourseId,CourseName,CourseUnit,CourseMasterName);
        }
    }
}
