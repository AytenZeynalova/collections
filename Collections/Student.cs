using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
   public  class Student
    {
        private int _no;
        public Student()
        {
            _no++;
            No = _no;
        }
        public int No { get; }
        public string FullName { get; set; }

       public Dictionary<string, int> Exams = new Dictionary<string, int>();
        
        public void AddExam(string examName, int point)
        {
            Exams.Add(examName, point);
        }
        
        public int GetExamResult(string examName)
        {
            foreach (var key in Exams.Keys)
            {
                if (examName == key)
                {
                    return Exams[examName];
                }
            }return -1;
        }

        public double GetExamAvg()
        {
            double sum = 0;
            int count = 0;
            double avg = 0;
            foreach (var item in Exams.Values)
            {
                count++;
                sum += item;
            }
            avg = sum / count;
            return avg;

        }
       
      

    }


}

