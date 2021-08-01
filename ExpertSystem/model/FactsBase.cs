using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpertSystem.model
{
    internal class FactsBase
    {
        protected List<IFact> facts;

        public List<IFact> Facts
        {
            get { return facts; }
        }

        public FactsBase()
        {
            facts = new List<IFact>();
        }

        public void Clear()
        {
            facts.Clear();
        }

        public void AddFact(IFact fact)
        {
            facts.Add(fact);
        }

        public IFact Search(String _name)
        {
            return facts.FirstOrDefault(x => x.Name().Equals(_name));
        }

        public Object Value(String _name)
        {
            IFact fact = Search(_name);
            if (fact != null)
            {
                return fact.Value();
            }
            return null;
        }
    }
}
