using System;
using System.Collections;

namespace final_exam_qviz3
{
    // Comparer კლასი ლექტორების გამოქვეყნებული სტატიების რაოდენობის მიხედვით კლებადობით სორტირებისთვის
    public class PublishedArticlesComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Lecturer lx = x as Lecturer;
            Lecturer ly = y as Lecturer;
            if (lx == null || ly == null) return 0;
            return ly.PublishedArticles.CompareTo(lx.PublishedArticles);
        }
    }
}
