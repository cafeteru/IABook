using System;

namespace ExpertSystem.model
{
    class BoolFact : IFact
    {
        protected String name;
        protected bool value;
        protected int level = 0;
        protected String question = null;

        public BoolFact(String _name, bool _value, String _question, int _level)
        {
            name = _name;
            value = _value;
            question = _question;
            level = _level;
        }

        public String Name()
        {
            return name;
        }

        public object Value()
        {
            return value;
        }

        public int Level()
        {
            return level;
        }

        public void SetLevel(int _level)
        {
            level = _level;
        }

        public string Question()
        {
            return question;
        }

        public override string ToString()
        {
            String res = "";
            if (!value)
            {
                res += "!";
            }
            res += name + " (" + level + ")";
            return res;
        }
    }
}
