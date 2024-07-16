using System;
using System.Collections;

namespace final_exam_qviz3
{
    // Comparer კლასი ლექტორების სამუშაო სტაჟის მიხედვით კლებადობით სორტირებისთვის
    public class WorkExperienceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Lecturer lx = x as Lecturer;
            Lecturer ly = y as Lecturer;
            if (lx == null || ly == null) return 0;
            return ly.WorkExperience.CompareTo(lx.WorkExperience);
        }
    }
}
