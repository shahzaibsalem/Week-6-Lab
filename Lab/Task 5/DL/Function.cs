using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5.BI;
using Task_5.UI;

namespace Task_5.DL
{
    public class Function
    {
       public static List<Students> stu = new List<Students>();
       public static List<Degree_Program> deg = new List<Degree_Program>();
       public static List<Subjects> subj = new List<Subjects>();
       public static List<Subjects> regSubj = new List<Subjects>();
       public static List<Degree_Program> regdeg = new List<Degree_Program>();
       public static List<Prefrences> pre = new List<Prefrences>();
       public static List<string> pref = new List<string>();
        public static List<regStudents> reg = new List<regStudents>();
       
        public static void Add_Student()
        {
            string name;
            int matric;
            int fsc;
            int ecat;
            double merit;
            bool flag=false;

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter matric marks:");
            matric = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc marks:");
            fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks:");
            ecat = int.Parse(Console.ReadLine());

            merit = ((matric * 0.30f)*100) + ((fsc*0.60f)*100)+((ecat*0.10f)*100);
            Console.WriteLine("Enter how many prefrences you want to enter:");
            int count = int.Parse(Console.ReadLine());
            for(int i =0; i<count; i++)
            {
                Console.WriteLine("Enter degree name:");
                string n = Console.ReadLine();
                foreach(Degree_Program d in deg)
                {
                    if(n==d.name)
                    {
                        flag = true;
                        pref.Add(n);
                        Prefrences p = new Prefrences(pref);
                    }
                    else
                    {
                        flag = false;
                    }
                } 
                if(flag==false)
                {
                    Console.WriteLine("Enter valid name!!!!");
                }
               
            }

            Students s = new Students(name, matric, fsc, ecat, merit);
            Add_Student_to_list(s);
        }

        public static void Add_reg_students(regStudents s)
        {
            reg.Add(s);
        }
        public static void Add_Preferences_to_List(Prefrences p)
        {
            pre.Add(p);
        }

        public static void Add_Degree()
        {
            string name;
            int duration;
            

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter duration:");
            duration = int.Parse(Console.ReadLine());

            Degree_Program d = new Degree_Program(name, duration);
            Add_Degree_to_list(d);

            Console.WriteLine("How many subjects you want to enter?");
            int count = int.Parse(Console.ReadLine());
            for(int i =0; i<count; i++)
            {
                string n;
                string code;
                int fee;
                Console.WriteLine("Enter name:");
                n = Console.ReadLine();
                Console.WriteLine("Enter code:");
                code = Console.ReadLine();
                Console.WriteLine("Enter fee:");
                fee = int.Parse(Console.ReadLine());
                Subjects m = new Subjects(n, code, fee);
                Add_Subjects_to_list(m);
            }
        }
        public static void Add_Student_to_list(Students s)
        {
            stu.Add(s);
        }
        public static void Add_Degree_to_list(Degree_Program s)
        {
            deg.Add(s);
        }
        public static void Add_Subjects_to_list(Subjects s)
        {
            subj.Add(s);
        }

        public static double Generate_Merit()
        {
            double high = 0;
            foreach(Students s in stu)
            {
                if(s.merit>high)
                {
                    high = s.merit;
                }
            }
            return high;
        }
        public static string Generate_Merit_Nme()
        {
            double high = 0;
            string name=" ";
            foreach (Students s in stu)
            {
                if (s.merit > high)
                {
                    high = s.merit;
                    name = s.name;
                }
            }
            return name;
        }

        public static void Print_Higher_Merit()
        {
            double output = Function.Generate_Merit();
            string name = Function.Generate_Merit_Nme();
            foreach (Students s in stu)
            {
                Console.WriteLine(s.name);
                Console.WriteLine(s.merit);
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("Highest Merit Student is:");
            Console.WriteLine(name);
            Console.WriteLine("Highest Merit  is:");
            Console.WriteLine(output);
            Console.WriteLine("__________________________________");

        }
        public static void Reg_Students()
        {
            int i = 0;
            if(pref==null)
            {
                Console.WriteLine("No preferences are found!!!!");
            }
            else
            {
                double high = 0;
                string name = " ";
                foreach (Students s in stu)
                {
                    if (s.merit > high)
                    {
                        high = s.merit;
                        name = s.name;
                    }
                }
                foreach(Students s in stu)
                {             
                    if(s.merit>=high)
                    {   
                        regStudents r = new regStudents(s.name, pre[i].pref[0]);                     
                        Add_reg_students(r);
                    }
                    else
                    {
                        Console.WriteLine(s.name + " did not get the admission!!!! ");
                    }
                    i++;
                }
            }
        }
        public static void See_Student_of_specific_program()
        {
            string name;
            bool flag = false;
            Console.WriteLine("Enter degree name:");
            name = Console.ReadLine();
            foreach(regStudents r in reg)
            {
                if(name==r.name)
                {
                    Console.WriteLine(r.name + "     " + r.degree);
                    flag = true;
                }
               
            }
            if(flag==false)
            {
                Console.WriteLine("Invalid input!!!!");
            }
        }

    }
}
