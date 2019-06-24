using System;
using System.Collections;

namespace ConsoleApp1
{
    public interface Parent2
    {
        void courses_Level5();
    }
    class ParentClass2 : Parent2
    {
        // Providing the implementation 
        // of courses_Level5() method 
        public void courses_Level5()
        {

            // Creating ArrayList 
            ArrayList My_list = new ArrayList();

            // Adding elements in the 
            // My_list ArrayList 
            My_list.Add("IT Support");
            My_list.Add("Web Programming and Interface Analysis and Design");
            My_list.Add("Content Management Systems and Frameworks");
            My_list.Add("Database Design and Integration ");
            My_list.Add("Introduction to Software Programming");
            My_list.Add("Software Testing and Security");
            My_list.Add("Professional Practice");

            Console.WriteLine("\nCourses provided in level 5 :");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
