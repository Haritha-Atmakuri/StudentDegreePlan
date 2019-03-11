using WebApplication1.Models;
using System;
using System.Linq;

namespace WebApplication1.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                      new Degree{ID = 1 , DegreeAbv = "ACS + 2" , DegreeName = "MS ACS+ 2", NumberOfTerms=  5},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            if (context.Credits.Any())
            {
                Console.WriteLine("Credits already exist.");
            }
            else
            {
                var credits = new Credit[]
                {
                        new Credit{CreditID =460 , CreditAbv ="DB" , CreditName ="Database" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =356 , CreditAbv ="NF" , CreditName ="Network Fundamentals" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =542 , CreditAbv ="542" , CreditName ="OOP" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =563 , CreditAbv ="563" , CreditName ="Web Apps" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =560 , CreditAbv ="560" , CreditName ="Advanced Databases" , IsSummer =1, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =664 , CreditAbv ="664-UX" , CreditName ="User Experince Design" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =618 , CreditAbv ="618-PM" , CreditName ="ProjectManagement" , IsSummer =1, IsSpring =0 , IsFall = 0},
                        new Credit{CreditID =555 , CreditAbv ="555-NS" , CreditName ="Network Security" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =691 , CreditAbv ="691-GDP1" , CreditName ="GDP1" , IsSummer =1, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =692 , CreditAbv ="692-GDP2" , CreditName ="GDP2" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =64 , CreditAbv ="Mobile" , CreditName ="643 or 644 Mobile" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =10 , CreditAbv ="E1" , CreditName ="Elective1" , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =20 , CreditAbv ="E2" , CreditName ="Elective2" , IsSummer =0, IsSpring =1 , IsFall = 1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");
                foreach (Credit d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }


            //Degree Credit
             if (context.DegreeCredits.Any())
            {
                Console.WriteLine("Degree Credit already exists!");
            }
            else
            {
                var degreeCredit = new DegreeCredit[]
                {
                    new DegreeCredit{DegreeCreditID = 1, DegreeID = "1" , CreditID = 460},
                    new DegreeCredit{DegreeCreditID = 2, DegreeID = "1" , CreditID = 356},
                    new DegreeCredit{DegreeCreditID = 3, DegreeID = "1" , CreditID = 542},
                    new DegreeCredit{DegreeCreditID = 4, DegreeID = "1" , CreditID = 563},
                    new DegreeCredit{DegreeCreditID = 5, DegreeID = "1" , CreditID = 560},
                    new DegreeCredit{DegreeCreditID = 6, DegreeID = "1" , CreditID = 618},
                    new DegreeCredit{DegreeCreditID = 7, DegreeID = "1" , CreditID = 618},
                    new DegreeCredit{DegreeCreditID = 8, DegreeID = "1" , CreditID = 555},
                    new DegreeCredit{DegreeCreditID = 9, DegreeID = "1" , CreditID = 691},
                    new DegreeCredit{DegreeCreditID = 10, DegreeID = "1" , CreditID = 692},
                    new DegreeCredit{DegreeCreditID = 11, DegreeID = "1" , CreditID = 6},
                    new DegreeCredit{DegreeCreditID = 12, DegreeID = "1" , CreditID = 10},
                    new DegreeCredit{DegreeCreditID = 13, DegreeID = "1" , CreditID = 20}
                    
                };  
                Console.WriteLine($"Inserted {degreeCredit.Length} new degree requirements");
                foreach (DegreeCredit d in degreeCredit)
                {
                        context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }

            //DegreePlan
             if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plan already exists!");
            }
            else
            {
                var degreePlan = new DegreePlan[]
                {
                new DegreePlan{DegreePlanID=7251, StudentID=533725, DegreePlanAbv="Slow and easy",DegreePlanName="Take a break in summer",DegreeId=1},
                new DegreePlan{DegreePlanID=7252, StudentID=533725, DegreePlanAbv="Super Fast", DegreePlanName="No break", DegreeId=1},
                new DegreePlan{DegreePlanID=7253, StudentID=534049, DegreePlanAbv="Slow and easy", DegreePlanName="As fast as I Can", DegreeId=1},
                new DegreePlan{DegreePlanID=7254, StudentID=534049, DegreePlanAbv="Slow and easy", DegreePlanName="Take less courses per semester",DegreeId=1},
                new DegreePlan{DegreePlanID=7255, StudentID=533767, DegreePlanAbv="Super Fast", DegreePlanName="More subjects in semesters",DegreeId=1},
                new DegreePlan{DegreePlanID=7256, StudentID=533767, DegreePlanAbv="Slow and Consistent", DegreePlanName="Take a break in summer",DegreeId=1}        
                };  
                Console.WriteLine($"Inserted {degreePlan.Length} new degree plans");
                foreach (DegreePlan d in degreePlan)
                {
                        context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            //Slot
             if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exists!");
            }
            else
            {
                var slot = new Slot[]
                {
                new Slot{SlotID=1, DegreePlanID=7251, Term=1, CreditID=460, Status="C"},
                new Slot{SlotID=2, DegreePlanID=7251, Term=1, CreditID=356, Status="C"},
                new Slot{SlotID=3, DegreePlanID=7251, Term=1, CreditID=563, Status="C"},
                new Slot{SlotID=4, DegreePlanID=7251, Term=1, CreditID=542, Status="C"},
                new Slot{SlotID=5, DegreePlanID=7251, Term=2, CreditID=555, Status="A"},
                new Slot{SlotID=6, DegreePlanID=7251, Term=2, CreditID=560, Status="A"},
                new Slot{SlotID=7, DegreePlanID=7251, Term=2, CreditID=6, Status="A"},
                new Slot{SlotID=8, DegreePlanID=7251, Term=3, CreditID=0, Status="-"},
                new Slot{SlotID=9, DegreePlanID=7251, Term=4, CreditID=691, Status="P"},
                new Slot{SlotID=10, DegreePlanID=7251, Term=4, CreditID=10, Status="P"},
                new Slot{SlotID=11, DegreePlanID=7251, Term=5, CreditID=20, Status="P"},
                new Slot{SlotID=12, DegreePlanID=7251, Term=5, CreditID=692, Status="P"},
                new Slot{SlotID=13, DegreePlanID=7251, Term=5, CreditID=664, Status="P"}

                };  
                Console.WriteLine($"Inserted {slot.Length} new slot");
                foreach (Slot d in slot)
                {
                        context.Slots.Add(d);
                }
                context.SaveChanges();
            }

            //Student
              if (context.Students.Any())
            {
                Console.WriteLine("Student already exists!");
            }
            else
            {
                var student = new Student[]
                {
                    new Student{StudentID=533725, FamilyName="Mamidi", GivenName="Prakash", Sid="S533725", CatPawsID=919569651},
                    new Student{StudentID=534049, FamilyName="Atmakuri", GivenName="Haritha", Sid="S534049", CatPawsID=919569607},
                    new Student{StudentID=533767, FamilyName="Badisa", GivenName="SaiRam", Sid="S533767", CatPawsID=919565612}


                };  
                Console.WriteLine($"Inserted {student.Length} new Students");
                foreach (Student d in student)
                {
                        context.Students.Add(d);
                }
                context.SaveChanges();
            }
            

            //Student Term

            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Term Requirements already exists!");
            }
            else
            {
                var studentTerm = new StudentTerm[]
                {
                    new StudentTerm{StudentTermID=11,StudentID=533726,DegreePlanID=7254,Term=1,TermAbbr="S19",TermName="Spring2019",NoOfCoursesTaken=4},
                    new StudentTerm{StudentTermID=12,StudentID=533726,DegreePlanID=7254,Term=2,TermAbbr="Su19",TermName="Summer2019",NoOfCoursesTaken=0},
                    new StudentTerm{StudentTermID=13,StudentID=533726,DegreePlanID=7254,Term=3,TermAbbr="F19",TermName="Fall2019",NoOfCoursesTaken=3},
                    new StudentTerm{StudentTermID=14,StudentID=533726,DegreePlanID=7254,Term=4,TermAbbr="S20",TermName="Spring2020",NoOfCoursesTaken=3},
                    new StudentTerm{StudentTermID=15,StudentID=533726,DegreePlanID=7254,Term=5,TermAbbr="Su20",TermName="Summer2020",NoOfCoursesTaken=3}

                };
                Console.WriteLine($"Inserted {studentTerm.Length} new student terms");
                foreach (StudentTerm st in studentTerm)
                {
                    context.StudentTerms.Add(st);
                }
                context.SaveChanges();
            }    
        }
    }
}