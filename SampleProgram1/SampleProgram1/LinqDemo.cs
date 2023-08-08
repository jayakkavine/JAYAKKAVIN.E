using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal class LinqDemo
    {
        public void ShowResults()
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            int highScoreCount = (
                                from score in scores
                                where score > 80
                                select score).Count();
            Console.WriteLine(highScoreCount);

            
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }


            int highScoresQuery = scores.Where(score => score > 80).Count();
            IEnumerable<int> high = scores.OrderDescending();
            //int scoreCount = highScoresQuery.Count();
            
            foreach (int testScore in high)
            {
                Console.WriteLine(testScore);
            }
            
            
            
        }
        }
    }
