using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Accomplishment
    {
        private String name;
        private int pointValue;
       
        public Accomplishment(String name, int pointValue)
        {
            this.name = name;
            this.pointValue = pointValue;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setPointValue(int pointValue)
        {
            this.pointValue = pointValue;
        }

        public String getName()
        {
            return name;
        }

        public int getPointValue()
        {
            return pointValue;
        }
    }
}
