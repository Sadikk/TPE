using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelingSalesmanProblem.Engine;

namespace TravelingSalesmanProblem.Core
{
    static class InitGen
    {
        /* Class used to perform the first generation */

        #region Public Methods
        public static List<Path> Gen(int size, List<Point> lp)
        {
            List<Path> result = new List<Path>();

            while (result.Count < size)
            {
                Path p = RandomPath(lp);
                if (CheckPath(lp, p) == true)
                    result.Add(p);
            }

            return result;
        }
        #endregion

        #region Private Methods
        private static Path RandomPath(List<Point> lp)
        {
            /* Generate a random path from an initial list of point */
            Path result;

            Random rng = new Random(); /* Shuffle the list */
            int n = lp.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Point value = lp[k];
                lp[k] = lp[n];
                lp[n] = value;
            }

            result = new Path(lp); /* Create a path with the shuffled list */

            return result;
        }

        private static bool CheckPath(List<Point> initial, Path p)
        {
            /* Check if the path is correct. (Only one usage per point, all points used, etc...) */
            if (p.Locations[0] != initial[0])
                return false;
            else if (p.Locations[p.Locations.Count - 1] != initial[initial.Count - 1])
                return false;

            foreach (Point point in p.Locations)
            {
                if (p.Locations.Count(x => x == point) > 1)
                    return false;
            }
            if (initial.Count != p.Locations.Count)
                return false;

            return true;
        }
        #endregion
    }
}
