using System;
using System.Collections;
using System.Collections.Generic;

namespace final_exam_qviz3
{
    // Lecturer კლასის განსაზღვრა შესაბამისი ველებით და ინტერფეისების იმპლემენტაციებით
    public class Lecturer : IEnumerable<Lecturer>, IEnumerator<Lecturer>, IComparable<Lecturer>, IComparer<Lecturer>, IEquatable<Lecturer>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public int WorkExperience { get; set; }
        public int PublishedArticles { get; set; }

        private int position = -1;

        // კონსტრუქტორი ველების ინიციალიზაციისთვის
        public Lecturer(string firstName, string lastName, string personalNumber, int workExperience, int publishedArticles)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            WorkExperience = workExperience;
            PublishedArticles = publishedArticles;
        }

        // IEnumerable ინტერფეისის იმპლემენტაცია
        public IEnumerator<Lecturer> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        // IEnumerator ინტერფეისის იმპლემენტაცია
        public bool MoveNext()
        {
            position++;
            return (position < 1); // since it's single object iterator
        }

        public void Reset()
        {
            position = -1;
        }

        public Lecturer Current
        {
            get
            {
                try
                {
                    return this;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            // No resources to release
        }

        // IComparable ინტერფეისის იმპლემენტაცია გამოქვეყნებული სტატიების რაოდენობით შედარებისთვის
        public int CompareTo(Lecturer other)
        {
            if (other == null) return 1;
            return this.PublishedArticles.CompareTo(other.PublishedArticles);
        }

        // IComparer ინტერფეისის იმპლემენტაცია გვარით შედარებისთვის
        public int Compare(Lecturer x, Lecturer y)
        {
            if (x == null || y == null) return 0;
            return x.LastName.CompareTo(y.LastName);
        }

        // IEquatable ინტერფეისის იმპლემენტაცია პირადი ნომრით ტოლობის გასამოწმებლად
        public bool Equals(Lecturer other)
        {
            if (other == null) return false;
            return this.PersonalNumber == other.PersonalNumber;
        }

        // ToString მეთოდის გადატვირთვა ლექტორის დეტალების დასაბეჭდად
        public override string ToString()
        {
            return $"{FirstName} {LastName}, Personal Number: {PersonalNumber}, Work Experience: {WorkExperience} years, Published Articles: {PublishedArticles}";
        }
    }
}
