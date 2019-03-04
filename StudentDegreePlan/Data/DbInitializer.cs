using StudentDegreePlan.Models;
using System;
using System.Linq;

namespace StudentDegreePlan.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degree.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                     new Degree{DegreeID = 1 , DegreeAbv = "ACS+2" , DegreeName = "MS ACS +2"},
                     new Degree{DegreeID = 2 , DegreeAbv = "ACS+DB" , DegreeName = "MS ACS+ DB"},
                     new Degree{DegreeID = 3 , DegreeAbv = "ACS+NF" , DegreeName = "MS ACS + NF"},
                     new Degree{DegreeID = 4 , DegreeAbv = "ACS" , DegreeName = "MS ACS"},
                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (DegreePlan d in degrees)
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
                        new Credit{CreditID =460 , CreditAbv =DB , CreditName =Database , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =356 , CreditAbv =NF , CreditName =Network Fundamentals , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =542 , CreditAbv =542 , CreditName =OOP , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =563 , CreditAbv =563 , CreditName =Web Apps , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =560 , CreditAbv =560 , CreditName =Advanced Databases , IsSummer =1, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =664 , CreditAbv =664-UX , CreditName =User Experince Design , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =618 , CreditAbv =618-PM , CreditName =ProjectManagement , IsSummer =1, IsSpring =0 , IsFall = 0},
                        new Credit{CreditID =555 , CreditAbv =555-NS , CreditName =Network Security , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =691 , CreditAbv =691-GDP1 , CreditName =GDP1 , IsSummer =1, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =692 , CreditAbv =692-GDP2 , CreditName =GDP2 , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =64 , CreditAbv =Mobile , CreditName =643 or 644 Mobile , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =10 , CreditAbv =E1 , CreditName =Elective1 , IsSummer =0, IsSpring =1 , IsFall = 1},
                        new Credit{CreditID =20 , CreditAbv =E2 , CreditName =Elective2 , IsSummer =0, IsSpring =1 , IsFall = 1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");
                foreach (DegreePlan d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }


            //Degree Credit
             if (context.DegreeCredit.Any())
            {
                Console.WriteLine("Degree Credit already exists!");
            }
            else
            {
                var degree = new DegreeCredit[]
                {
                    new DegreeCredit{DegreeCreditID = 1, DegreeID = '1' , CreditID = '460'}
                    new DegreeCredit{DegreeCreditID = 2, DegreeID = '1' , CreditID = '356'}
                    new DegreeCredit{DegreeCreditID = 3, DegreeID = '1' , CreditID = '542'}
                    new DegreeCredit{DegreeCreditID = 4, DegreeID = '1' , CreditID = '563'}
                    new DegreeCredit{DegreeCreditID = 5, DegreeID = '1' , CreditID = '560'}
                    new DegreeCredit{DegreeCreditID = 6, DegreeID = '1' , CreditID = '618'}
                    new DegreeCredit{DegreeCreditID = 7, DegreeID = '1' , CreditID = '618'}
                    new DegreeCredit{DegreeCreditID = 8, DegreeID = '1' , CreditID = '555'}
                    new DegreeCredit{DegreeCreditID = 9, DegreeID = '1' , CreditID = '691'}
                    new DegreeCredit{DegreeCreditID = 10, DegreeID = '1' , CreditID = '692'}
                    new DegreeCredit{DegreeCreditID = 11, DegreeID = '1' , CreditID = '6'}
                    new DegreeCredit{DegreeCreditID = 12, DegreeID = '1' , CreditID = '10'}
                    new DegreeCredit{DegreeCreditID = 13, DegreeID = '1' , CreditID = '20'}

                };  
                Console.WriteLine($"Inserted {DegreeCredit.Length} new degree requirements");
                foreach (DegreeCredit d in degree){
                        context.DegreeCredit.Add(d);
                }
                context.SaveChanges();
            }

            //Student Term

            if (context.StudentTerm.Any())
            {
                Console.WriteLine("Student Term Requirements already exists!");
            }
            else
            {
                var studentTerm = new StudentTerm[]
                {
                    new StudentTerm{StudentTermID=11,StudentID=533726,DegreePlanID=7254,Term=1,TermAbbr=S19,TermName=Spring2019,No.OfCoursesTaken=4}
                    new StudentTerm{StudentTermID=12,StudentID=533726,DegreePlanID=7254,Term=2,TermAbbr=Su19,TermName=Summer2019,No.OfCoursesTaken=0}
                    new StudentTerm{StudentTermID=13,StudentID=533726,DegreePlanID=7254,Term=3,TermAbbr=F19,TermName=Fall2019,No.OfCoursesTaken=3}
                    new StudentTerm{StudentTermID=14,StudentID=533726,DegreePlanID=7254,Term=4,TermAbbr=S20,TermName=Spring2020,No.OfCoursesTaken=3}
                    new StudentTerm{StudentTermID=15,StudentID=533726,DegreePlanID=7254,Term=5,TermAbbr=Su20,TermName=Summer2020,No.OfCoursesTaken=3}

                };
                Console.WriteLine($"Inserted {studentTerm.Length} new student terms");
                foreach (StudentTerm st in studentTerm)
                {
                    context.StudentTerm.Add(d);
                }
                context.SaveChanges();
            }    
        }
    }
}