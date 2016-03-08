using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProject
{

    public class Class1
    {
        private string myName = "N/A";
        private int myAge = 0;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public int Age
        {
            get{  return myAge;}
            set{ myAge = value;}
        }
    }
}