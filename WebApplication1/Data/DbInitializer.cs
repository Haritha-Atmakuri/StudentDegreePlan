using DegreePlan.Models;
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
           
            

        }

    }
}