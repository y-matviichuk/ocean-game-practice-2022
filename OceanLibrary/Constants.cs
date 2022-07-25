using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanLibrary
{
    public struct Constants
    {
        public const int maxRows = 40;
        public const int maxCols = 100;

        public const int maxObstacles = 200;
        public const int maxPredators = 100;
        public const int maxPreys = 500;
        public const int maxIterations = 10000;

        public const int defaultRows = 25;
        public const int defaultColumns = 75;

        public const int defaultNumObstacles = 75;
        public const int defaultNumPredators = 20;
        public const int defaultNumPreys = 150;
        public const int defaultNumIterations = 1000;

        public const char defaultImage = '-';
        public const char defaultPredatorImage = 'S';
        public const char defaultPreyImage = 'f';
        public const char defaultobstacleImage = '#';

        public const int timeToFeed = 6;
        public const int timeToReproduce = 6;
    }
}
