using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Topic
    {
        private String name;
        private List<Accomplishment> accomplishments;

        public Topic(String name)
        {
            this.name = name;
            accomplishments = new List<Accomplishment>();
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setAccomplishments(List<Accomplishment> accomplishments)
        {
            this.accomplishments = accomplishments;
        }

        public String getName()
        {
            return name;
        }

        public List<Accomplishment> getAccomplishments()
        {
            return accomplishments;
        }

        public void add(Accomplishment acc)
        {
            accomplishments.Add(acc);
        }
    }
}
