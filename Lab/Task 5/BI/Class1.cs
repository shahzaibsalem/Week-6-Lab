using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.BI
{
    public class Students
    {
        public string name;
        public int matric_marks;
        public int fsc_marks;
        public int ecat_marks;
        public double merit;
        
        public Students(string name,int matric_marks,int fsc_marks,int ecat_marks,double merit)
        {
            this.name = name;
            this.matric_marks = matric_marks;
            this.fsc_marks = fsc_marks;
            this.ecat_marks = ecat_marks;
            this.merit = merit;
        }

        public Students()
        {

        }

    }
    public class Degree_Program
    {
       public string name;
       public int duration;

        public Degree_Program(string name,int duration)
        {
            this.name = name;
            this.duration = duration;
        }

        public Degree_Program()
        {

        }
     
    }
    public class Subjects
    {
       public string name;
       public string code;
        public int fee;
        
        public Subjects(string name,string code,int fee)
        {
            this.name = name;
            this.code = code;
            this.fee = fee;
        }

        public Subjects()
        {

        }

    }

    public class Prefrences
    {
        public List<string> pref=new List<string>();

        public Prefrences(List<string> pref)
        {
            this.pref = pref;
        }
    }
    public class regStudents
    {
       public  string name;
       public string degree;

        public regStudents(string name,string degree)
        {
            this.name = name;
            this.degree = degree;
        }
    }

}
