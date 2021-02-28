using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public int m_nNumber;
        public int m_nScore;

        public Student(int nNumber, int nScore)
        {
            m_nNumber = nNumber;
            m_nScore = nScore;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int nTotal = 0;
            double dMean = 0;
            Array arrRecord = Array.CreateInstance(typeof(Student), 5);

            Console.WriteLine("5명의 학생 성적을 입력합니다.");

            //학생 점수 Student class에 입력
            for(int i = 0; i < 5; i++)
            {
                string strScore = Console.ReadLine();
                arrRecord.SetValue(new Student(i + 1, Convert.ToInt32(strScore)), i);
                nTotal += ((Student)arrRecord.GetValue(i)).m_nScore;
            }

            for(int i = 0; i < arrRecord.Length; i++)
            {
                int nScore = ((Student)arrRecord.GetValue(i)).m_nScore;
                string strGrage = "F";

                if (nScore >= 90)
                    strGrage = "A";
                else if (nScore >= 80)
                    strGrage = "B";
                else if (nScore >= 70)
                    strGrage = "C";
                else if (nScore >= 60)
                    strGrage = "D";

                Console.WriteLine("{0}번 학생 성적 : {1}, 등급 : {2}", i + 1, nScore, strGrage);
            }

            dMean = (double)nTotal / arrRecord.Length;
            Console.WriteLine("총점 : {0}, 평균 : {1}", nTotal, dMean);
        }
    }
}
