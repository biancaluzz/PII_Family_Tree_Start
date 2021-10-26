using System;

namespace Library
{
    public abstract class Visitor
    {
        public abstract int VisitAgeSum(Node person);
        public abstract int VisitOldest(Node person);
        public abstract string VisitLargestName(Node person);
    }
}