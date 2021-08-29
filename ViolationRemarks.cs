using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRMSBusinessLayer
{
    
    public class ViolationRemarks 
    {
        static public List<string> _violation = new List<string>();
        static public List<string> Violation
        {
            get { return _violation; }
        }
        static private List<string> _typeofviolation = new List<string>();
        static public List<string> TypeOfViolation
        {
            get { return _typeofviolation; }
        }
        static public List<string> _offense = new List<string>();
        static public List<string> Offense
        {
            get { return _offense; }
        }


    }
}
