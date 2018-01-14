using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaces;


namespace HouseBilding
{
    class Worker : House,IWorker
    {
       
        public void Work()
        {
            IPart home = new House();
            if (home.part < 1)
            {
                IPart b = new Basement();
                if (b.part < 1)
                {
                    b.Do();
                    return;
                }

                if (b.part == 1)
                {
                    IPart w = new Walls();
                    if (w.part < 4)
                    {
                        w.Do();
                        return;
                    }
                    if (w.part == 4)
                    {
                        IPart win = new Window();
                        if (win.part < 4) win.Do();
                        if (win.part == 4)
                        {
                            IPart d = new Door();
                            if (d.part < 1)
                            {
                                d.Do();
                                return;
                            }
                            if (d.part == 1)
                            {
                                IPart r = new Roof();
                                if (r.part < 1)
                                {
                                    r.Do();
                                    return;
                                }
                                if (r.part == 1)
                                {
                                    Console.WriteLine("\t\tTeamLeader Said!");
                                    IWorker lead = new TeamLeader();
                                    lead.Work();
                                }
                            }
                        }

                    }



                }
            }
            if (home.part > 1)
            {
                IWorker lead = new TeamLeader();
                lead.Work();
            }
            
        }
    }
    class Team : IWorker
    {
       
       public IWorker[] work = new Worker[6];
        public Team()
        {
            for(int i = 0; i < 6; i++)
            {
                work[i] = new Worker();
            }
        }
        public void Work()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine((i + 1) + " worker");
                work[i].Work();
                Console.WriteLine();
               
            }
        }
    }
    class TeamLeader : IWorker
    {
        public void Work()
        {
            IPart home = new House();
            home.Do();
            Console.WriteLine("      #");
            Console.WriteLine("      |");
            Console.WriteLine("     /\\");
            Console.WriteLine("    /**\\");
            Console.WriteLine("   /****\\");
            Console.WriteLine("  /******\\");
            Console.WriteLine(" |--------|");
            Console.WriteLine(" |********|");
            Console.WriteLine(" |+-+  +-+|");
            Console.WriteLine(" |+-+  +-+|");
            Console.WriteLine(" |********|");
            Console.WriteLine(" |========|");
            Console.WriteLine(" |________|");

        }
        public void Check()
        {
            
            IPart home = new House();
            IPart wall = new Walls();
            IPart bas = new Basement();
            IPart win = new Window();
            IPart door = new Door();
            IPart roof = new Roof();
            if (home.part == 1) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tYour House is DONE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            
            if ((bas.part >= 1))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\tBasement is DONE");
                if (wall.part >= 1)
                {
                    Console.WriteLine("\t\t" + wall.part + " wall(s) - DONE");
                    if (win.part >= 1)
                    {
                        Console.WriteLine("\t\t" + win.part + " window(s) - DONE");
                        if(door.part == 1)
                        {
                            Console.WriteLine("\t\tDoor is DONE");
                            if (roof.part == 1)
                            {
                                Console.WriteLine("\t\tRoof is DONE");
                                
                            }
                        }

                    }
                }
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
           
        }
        
    }
    class House : IPart
    {
        static int home = 0;
        public int part
        {
            get
            {
                return home;
            }
        }

        public void Do()

        {
            home++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t" + home + " House is done!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    class Door : IPart
    {
        public static int door = 0;
        public int part { get { return door; } }

        public void Do()
        {
            if (door < 1)
            {
                door++;
                Console.WriteLine("Door is done!");
            }
            if (door == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Door is alreday done!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            }
    }


    class Window : IPart
    {
        public static int wind = 0;
        public int part
        {
            get
            {
                return wind;
            }
        }

        public void Do()
        {
            if (wind < 4)
            {
                wind++;
                Console.WriteLine(wind+" window is Done!\n\tIt's rest " + (4 - wind) + " windows");
            }
            if (wind == 4) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Windows is alreday done!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }


    class Roof : IPart
    {
        public static int roof = 0;
        public int part
        {
            get
            {
                return roof;
            }
        }

        public void Do()
        {
            if (roof < 1)
            {
                roof++;
                Console.WriteLine("Roof is done!");
            }
            if (roof == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Roof is alreday done!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            }
    }
    class Basement : IPart
    {
        public static int basement = 0;
        public int part { get { return basement; } }
        public void Do()
        {
            if (basement < 1)
            {
                basement++;
                Console.WriteLine("Basement Done!");
            }
            if (basement == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Basement is already done!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            }
    }
    public class Walls:IPart
    {
        public static int wall = 0;
        public int part { get { return wall; } }

        public void Do()
        {
            if (wall < 4)
            {
                wall++;
                Console.WriteLine(wall+" wall is Done!\n\tIt's rest " + (4 - wall) + " walls");
               
            }         
            if(wall==4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Done Walls!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tLet's bild your Dream-house!");
            Console.WriteLine();
            Console.WriteLine("\t\tFirst team is starting..");
            Team team = new Team();
            team.Work();
            Console.WriteLine();
            Console.WriteLine("\t\tTeamLeader bacame to check work");
            TeamLeader tm = new TeamLeader();
            tm.Check();
            Console.WriteLine();
            Console.WriteLine("\t\tContinue to building.. Second team");
            Team team2 = new Team();
            team2.Work();
            Console.WriteLine();
            Console.WriteLine("\t\tTeamLeader bacame to check work");
            tm.Check();


            /*1.	Реализовать программу “Строительство дома” 
  Реализовать: 
  ●	Классы
  ○	House (Дом), Basement (Фундамент), Walls (Стены), Door (Дверь), Window (Окно), Roof (Крыша);
  ○	Team (Бригада строителей), Worker (Строитель), TeamLeader (Бригадир).

  ●	Интерфейсы
  ○	IWorker, IPart.

  Все части дома должны реализовать интерфейс IPart (Часть дома), 
  для рабочих и бригадира предоставляется базовый интерфейс IWorker (Рабочий).  
  Бригада строителей (Team) строит дом (House). 
  Дом состоит из фундамента (Basement), стен (Wall), окон (Window), дверей (Door), крыши (Part).
  Согласно проекту, в доме должно быть 1 фундамент, 4 стены, 1 дверь, 4 окна и 1 крыша.
   
  Бригада начинает работу, и строители последовательно “строят” дом, 
  начиная с фундамента. 
  
            Каждый строитель не знает заранее, на чём завершился
  предыдущий этап строительства, поэтому он “проверяет”, что уже построено
  и продолжает работу.
  
            Если в игру вступает бригадир (TeamLeader),
  он не строит, а формирует отчёт, что уже построено и какая часть работы выполнена. 

  В конечном итоге на консоль выводится сообщение, что строительство
  дома завершено и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).

  ДОПОЛНИТЕЛЬНО.
  1.	Создать интерфейс IStudent: 
  ●	string Name { get; set; }
  ●	string FullName { get; set; }
  ●	int[] Grades { get; set; }
  ●	String GetName()
  ●	String GetFullName() 
  ●	Double GetAvgGrade() 
  Наследовать от интерфейса класс Student и реализовать его.
  */
            Console.WriteLine();
            Console.WriteLine();

            int[][] Grades = new int[3][];
            Grades[0] = new int[]{ 2, 3, 3, 2, 4, 5, 2, 3, 4, 5 };
            Grades[1] = new int[] { 4, 5, 5, 4, 3, 4, 5, 4, 4, 3 };
            Grades[2] = new int[] { 3, 4, 3, 4, 5, 4, 3, 2, 3, 4 };
            Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine(" \t\t\tСписок Студентов и их средний бал");
            Console.ForegroundColor = ConsoleColor.White;
            Student[] st = new Student[3];
            st[0]=new Student("Petr","Ivanov",Grades[0]);
         
            st[1] = new Student("Anna", "Marie", Grades[1]);
            
            st[2] = new Student("Daniil", "Kim", Grades [2]);

            int[] grad = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grad[i] += Grades[i][j];
                }
            }

            string name = "";
            string fln = "";
            double avg = 0.0;

            for(int i = 0; i < st.Length; i++)
            {
               
                name =st[i].GetName();
                fln=st[i].GetFullName();

                avg=st[i].GetAvgGrade(grad[i]);
                Console.WriteLine(name + " " + fln + " средний бал = " + avg);
            }

            Console.WriteLine();
            
          
           
        }
    }
}
