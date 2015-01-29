using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSalesmanProblem.Engine
{
    class Path
    {
        /* Class representing a path */

        #region Fields
        public List<Point> Locations; /* List of the genes/points */
        public readonly Point StartingPoint
        {
            get { return Locations[0]; }
        }
        #endregion

        #region Constructors
        public Path(List<Point> Lp)
        {
            this.Locations = Lp;
        }
        #endregion

        #region Public Methods
        public int Distance()
        {
            /* Return the total distance of the path */
            int d = 0;
            for (int i = 0; i<Locations.Count ;i++)
            {
                if (i+1 < Locations.Count)
                    d += Locations[i].GetDistance(Locations[i + 1]);
            }
            return d;
        }

        public void Mute()
        {
            /* Random mutation of the chromosome */
            Random r = new Random();

            int min = 0;
            int max = Locations.Count;

            SwapLocations(r.Next(min,max), r.Next(min,max));

        }
        #endregion

        #region Private Methods
        private void SwapLocations(int index1, int index2)
        {
            /* Swap two genes in the chromosome */
            if (this.Locations == null)
                throw new ArgumentNullException("locations");

            if (index1 < 0 || index1 >= this.Locations.Count)
                throw new ArgumentOutOfRangeException("index1");

            if (index2 < 0 || index2 >= this.Locations.Count)
                throw new ArgumentOutOfRangeException("index2");

            var location1 = this.Locations[index1];
            var location2 = this.Locations[index2];
            this.Locations[index1] = location2;
            this.Locations[index2] = location1;
        }
        #endregion
    }
}
