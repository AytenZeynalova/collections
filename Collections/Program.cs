using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            string answer = "";
            string fullName = "";
            int no;
            string strNo;
            string examname = "";
            int point;
            string strpoint;
            do
            {
                Console.WriteLine("Menu:");
                
                Console.WriteLine("1. Telebe elave et\n 2. Telebeye imtahan elave et\n 3. Telebenin bir imtahan balına bax\n 4. Telebenin bütün imtahanlarını göster\n 5. Telebenin imtahan ortalamasını göster\n 6. Telebeden imtahan sil\n 0. Proqramı bitir");
               answer= Console.ReadLine();
                if (answer == "1")
                {
                    do
                    {
                        Console.WriteLine("telebenin adini daxil edinL");
                        fullName = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(fullName));

                    Student student = new Student();
                    student.FullName = fullName;
                    Students.Add(student);

                }else if (answer == "2")
                {

                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin:");
                        strNo = Console.ReadLine();
                        
                    } while (!int.TryParse(strNo, out no));


                    do
                    {
                        Console.WriteLine("imtahanin adini daxil edinL");
                        examname = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(examname));

                    do
                    {
                        Console.WriteLine("imtahanin balini daxil edinL");
                        strpoint  = Console.ReadLine();

                    } while (!int.TryParse(strpoint,out point));


                    foreach (var student in Students)
                    {
                        if (student.No == no)
                        {
                            student.AddExam(examname, point);
                        }
                        
                    }

                }

                else if (answer == "3")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin:");
                        strNo = Console.ReadLine();

                    } while (!int.TryParse(strNo, out no));


                    do
                    {
                        Console.WriteLine("imtahanin adini daxil edinL");
                        examname = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(examname));


                    foreach (var student in Students)
                    {
                        if (no == student.No)
                        {
                            
                            Console.WriteLine($"telebenin imtahan bali:{student.GetExamResult(examname)}");

                        }

                    }

                }
                else if (answer == "4")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin:");
                        strNo = Console.ReadLine();

                    } while (!int.TryParse(strNo, out no));


                    foreach (var student in Students)
                    {
                        if (no == student.No)
                        {
                            foreach (var item in student.Exams)
                            {
                                Console.WriteLine($"imtahan adi {item.Key}");
                                Console.WriteLine($"imtahan bali {item.Value}");

                            }
                            
                        }

                    }

                }
                else if (answer == "5")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin:");
                        strNo = Console.ReadLine();

                    } while (!int.TryParse(strNo, out no));

                    foreach (var item in Students)
                    {
                        if(item.No== no)
                        {
                           
                            Console.WriteLine(item.GetExamAvg());
                        }


                    }
                }

                else if (answer == "6")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin:");
                        strNo = Console.ReadLine();

                    } while (!int.TryParse(strNo, out no));

                    do
                    {
                        Console.WriteLine("imtahanin adini daxil edinL");
                        examname = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(examname));

                    foreach (var item in Students)
                    {
                        if (item.No == no)
                        {
                            item.Exams.Remove(examname);
                        }
                    }

                }


            } while ( answer != "0");

           
        }
    }
}
