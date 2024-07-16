using System;
using System.Collections;

namespace final_exam_qviz3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList შექმნა ლექტორების ობიექტების შესანახად
            ArrayList lecturers = new ArrayList
            {
                new Lecturer("John", "Doe", "123456789", 15, 10),
                new Lecturer("Jane", "Smith", "987654321", 10, 20),
                new Lecturer("Alice", "Johnson", "555555555", 5, 5),
                new Lecturer("Bob", "Williams", "444444444", 8, 12)
            };

            // გამოქვეყნებული სტატიების რაოდენობით (კლებადობით) სორტირება
            lecturers.Sort(new PublishedArticlesComparer());
            Console.WriteLine("Sorted by Published Articles (descending):");
            foreach (Lecturer lecturer in lecturers)
            {
                Console.WriteLine(lecturer);
            }

            // გვარის მიხედვით (ანბანურად) სორტირება
            lecturers.Sort(new LastNameComparer());
            Console.WriteLine("\nSorted by Last Name (alphabetically):");
            foreach (Lecturer lecturer in lecturers)
            {
                Console.WriteLine(lecturer);
            }

            // სამუშაო სტაჟის მიხედვით (კლებადობით) სორტირება
            lecturers.Sort(new WorkExperienceComparer());
            Console.WriteLine("\nSorted by Work Experience (descending):");
            foreach (Lecturer lecturer in lecturers)
            {
                Console.WriteLine(lecturer);
            }
        }
    }
}

//შექმენით კლასი Lecturer შემდეგი ველებით:სახელი, გვარი, პირადი ნომერი, სამუშაო სტაჟი, გამოქვეყნებული სტატიების რაოდენობა.

//შექმენით Lecturer კლასის რამდენიმე ობიექტი და განათავსეთ ისინი ArrayList-ში. 

//გადატვირთეთ Lecturer კლასისთვის IEnumerable, IEnumerator, IComparable, IComparer და IEquatable ინტერფეისები.

//დაალაგეთ Lecturer კლასის ობიექტების კოლექცია სორტირების მეთოდის გამოყენებით შემდეგნაირად:
//ა) გამოქვეყნებული სტატიების რაოდენობის მიხედვით კლებადობით;
//ბ) გვარის მიხედვით ანბანური თანმიმდევრობით;
//გ) სამუშაო სტაჟის მიხედვით კლებადობით;