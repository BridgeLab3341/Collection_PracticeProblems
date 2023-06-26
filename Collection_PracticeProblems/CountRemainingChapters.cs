using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_PracticeProblems
{
    public class CountRemainingChapters
    {
        public void CountChapters()
        {
            Console.WriteLine("Enter the number of Chapters");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Tuple<int, int>> chapters = new List<Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter starting page number of chapter ");
                int startpage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ending page number of chapter ");
                int endpage = Convert.ToInt32(Console.ReadLine());
                chapters.Add(new Tuple<int, int>(startpage, endpage));
            }
            Console.WriteLine("Enter the current reading page");
            int k = Convert.ToInt32(Console.ReadLine());
            int remainingChapters = CountRemainingChapter(n, chapters, k);
            Console.WriteLine("Number of chapters yet to read: " + remainingChapters);
        }
        public static int CountRemainingChapter(int n,List<Tuple<int, int>>chapters,int k)
        {
            int remainingChapters = 0;
            for(int i=0; i<n;i++)
            {
                Tuple<int, int> chapter = chapters[i];
                int startpage=chapter.Item1;
                int endpage=chapter.Item2;
                if(startpage <=k && k <= endpage)
                {
                    remainingChapters = n - i;
                    break;
                }
            }
            return remainingChapters;
        }
    }
}
