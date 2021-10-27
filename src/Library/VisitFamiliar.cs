using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitFamiliar : Visitor
    {
        public override void VisitAgeSum(Node person)
        {
            int result = 0;
            foreach (Person familiar in family)
            {
                result =+ familiar.Age;
            }
            Console.WriteLine (result);
        }
        
        public override void VisitOldest(Node person)
        {
            int result = 0;
            foreach (Person familiar in family)
            {
                if (familiar.Age > result)
                {
                    result = familiar.Age;
                }
            }
            Console.WriteLine (result);
        }

        public override void VisitLargestName(Node person)
        {
            string result = "";
            foreach (Person familiar in family)
            {
                if (familiar.Name.Length > result.Length)
                {
                    result = familiar.Name;
                }
            }
            Console.WriteLine (result);
        }
    }
}