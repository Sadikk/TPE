using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelingSalesmanProblem.Engine;

namespace TravelingSalesmanProblem.Core
{
    class Core
    {
        #region Fields
        List<Path> Listpath;
        #endregion

        #region Constructors
        public Core(List<Path> Lp)
        {
            this.Listpath = Lp;
        }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods
        private List<Path> BestOne(List<Path> lp, int howmany)
        {
            /* Return the best chromosomes */
            List<Path> result = new List<Path>();

            lp.Sort(new PathSorter());
            for (int i = 0; i<howmany;i++)
            {
                result.Add(lp[i]);
            }

            return result;
        }

        private List<Path> DoCrossOver(List<Path> lp)
        {
            /* Reproduce chromosomes */
            List<Path> result = new List<Path>();
            Path temp = null;
            foreach (Path p in lp)
            {         
                if (temp != null)
                    result.Add(Breed(p, temp));
                temp = p;
            }

            /* Check and correct mistakes */
            foreach(Path p in result)
            {
                foreach (Point point in lp[0].Locations)
                {
                    if (!p.Locations.Contains(point))
                    {
                        int i = DoublonIndex(p);
                        if (i != -1)
                            p.Locations[i] = point;
                    }
                }
            }

            return result;
        }

        private Path Breed(Path father, Path mother)
        {
            Random rand = new Random();
            Point[] genes = new Point[father.Locations.Count];
            Point[] map = new Point[father.Locations.Count + 1]; //create a map to map the indices
            int crossoverPoint1 = rand.Next(1, father.Locations.Count - 2); //select 2 crossoverpoints, without the first and last nodes, cuz they are always the same
            int crossoverPoint2 = rand.Next(1, father.Locations.Count - 2);
            father.Locations.CopyTo(genes, 0); //give child all genes from the father
            for (int i = 0; i < genes.Length; i++) //create the map
            {
                map[i] = genes[i];
            }
            //int[] genesToCopy = new int[Math.Abs(crossoverPoint1 - crossoverPoint2)]; //allocate space for the mother genes to copy
            if (crossoverPoint1 > crossoverPoint2) //if point 1 is bigger than point 2 swap them
            {
                int temp = crossoverPoint1;
                crossoverPoint1 = crossoverPoint2;
                crossoverPoint2 = temp;
            }
            //Console.WriteLine("copy mother genes into father genes from {0} to {1}", crossoverPoint1, crossoverPoint2);
            for (int i = crossoverPoint1; i <= crossoverPoint2; i++) //from index one to the 2nd
            {
                Point value = mother.Locations[i];
                Point t = genes[map.ToList().IndexOf(value)]; //swap the genes in the child
                genes[map.ToList().IndexOf(value)] = genes[i];
                genes[i] = t;
                t = map[genes.ToList().IndexOf(map[map.ToList().IndexOf(value)])]; //swap the indices in the map
                map[genes.ToList().IndexOf(map[map.ToList().IndexOf(value)])] = map[genes.ToList().IndexOf(map[i])];
                map[genes.ToList().IndexOf(map[i])] = t;
            }
            Path child = new Path(genes.ToList());
            return child;
        }

        private int DoublonIndex(Path p)
        {
            /* Return the index of the element which is x2 */
            foreach (Point point in p.Locations)
            {
                if (p.Locations.Count(x=>x == point) > 1)
                    return p.Locations.IndexOf(point);
            }
            return -1;
        }
        #endregion
    }
}
