using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVRMSBusinessLayer
{
    
    public class StudentInformation
    {
        static public List<string> _studentnumber = new List<string>();
        static private List<string> _studentname = new List<string>();
        static private List<int> _studentlevel = new List<int>();
        static public List<string> _studentsection = new List<string>();
        static private List<string> _studentadviser = new List<string>();

        static public List<string> StudentNumber
        {
            get { return _studentnumber; }
        }
        static public List<string> StudentName
        {
            get { return _studentname; }
        }
        static public List<int> StudentLevel
        {
            get { return _studentlevel; }
        }
        static public List<string> Section
        {
            get { return _studentsection; }
        }
        static public List<string> Adviser
        {
            get { return _studentadviser; }
        }
        static public void AddStudentNumber(string StudentNumber)
        {
            _studentnumber.Add(StudentNumber);
        }
        static public void AddStudentName(string StudentName)
        {
            _studentname.Add(StudentName);
        }
        static public void AddYearLevel(int StudentLevel)
        {
            _studentlevel.Add(StudentLevel);
        }
        static public void AddSection(string Section)
        {
            _studentsection.Add(Section);
        }
        static public void AddAdviser(string StudentAdviser)
        {
            _studentadviser.Add(StudentAdviser);
        }

    }
}
