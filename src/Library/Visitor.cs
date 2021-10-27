using System.Collections.Generic;

namespace Library
{
    public abstract class Visitor
    {
        public List<Person> family;

        public abstract void VisitAgeSum(Node person);
        public abstract void VisitOldest(Node person);
        public abstract void VisitLargestName(Node person);

    }
}