using WebApplication1.Models;
using System;
using System.Linq;

namespace WebApplication1.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
           
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree {DegreeId = 1, DegreeAbbr="ACS+2", DegreeName="MS ACS+2", NumberOfTerms=4},
                    new Degree {DegreeId = 2, DegreeAbbr="ACS+DB", DegreeName="MS ACS+DB", NumberOfTerms=4},
                    new Degree {DegreeId = 3, DegreeAbbr="ACS+NF", DegreeName="MS ACS+NF", NumberOfTerms=4},
                    new Degree {DegreeId = 4, DegreeAbbr="ACS", DegreeName="MS ACS", NumberOfTerms=4},

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
                    new Credit {CreditId=460, CreditAbbr="DB", CreditName="Databases", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=356, CreditAbbr="NF", CreditName="Network Fundamentals", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=542, CreditAbbr="542", CreditName="OOPS with Java", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=563, CreditAbbr="563", CreditName="Web Apps", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=560, CreditAbbr="560", CreditName="Advanced Databases", IsSummer=1, IsSpring=1, IsFall=1},
                    new Credit {CreditId=664, CreditAbbr="664-UX", CreditName="User Experience", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=618, CreditAbbr="618-PM", CreditName="Project Management", IsSummer=1, IsSpring=0, IsFall=0},
                    new Credit {CreditId=555, CreditAbbr="555-NS", CreditName="Network Security", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=691, CreditAbbr="691-GDP1", CreditName="GDP1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=692, CreditAbbr="692-GDP2", CreditName="GDP2", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=6, CreditAbbr="Mobile", CreditName="643 or 644 Mobile", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=10, CreditAbbr="E1", CreditName="Elective 1", IsSummer=0, IsSpring=1, IsFall=1},
                    new Credit {CreditId=20, CreditAbbr="E2", CreditName="Elective 2", IsSummer=0, IsSpring=1, IsFall=1},

                };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit d in credits)
                {
                    context.Credits.Add(d);
                }
                context.SaveChanges();
            }


           

            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
                
            }
            else
            {
                var students = new Student[]
                {
                    new Student {StudentId=533725, Family="Mamidi", Given="Prakash", N919=919569651},
                    new Student {StudentId=534049, Family="Haritha", Given="Atmakuri", N919=919569607},
                    new Student {StudentId=533767, Family="Badisa", Given="SaiRam", N919=919565612},

                };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }




            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("DegreeCredits already exist.");
                

            }
            else
            {
                var degreeCredits = new DegreeCredit[]
                {
                        new DegreeCredit {DegreeCreditId=1, DegreeId=1, CreditId=460},
                        new DegreeCredit {DegreeCreditId=2, DegreeId=1, CreditId=356},
                        new DegreeCredit {DegreeCreditId=3, DegreeId=1, CreditId=542},
                        new DegreeCredit {DegreeCreditId=4, DegreeId=1, CreditId=563},
                        new DegreeCredit {DegreeCreditId=5, DegreeId=1, CreditId=560},
                        new DegreeCredit {DegreeCreditId=6, DegreeId=1, CreditId=618},
                        new DegreeCredit {DegreeCreditId=7, DegreeId=1, CreditId=664},
                        new DegreeCredit {DegreeCreditId=8, DegreeId=1, CreditId=555},
                        new DegreeCredit {DegreeCreditId=9, DegreeId=1, CreditId=691},
                        new DegreeCredit {DegreeCreditId=10, DegreeId=1, CreditId=692},
                        new DegreeCredit {DegreeCreditId=11, DegreeId=1, CreditId=6},
                        new DegreeCredit {DegreeCreditId=12, DegreeId=1, CreditId=10},
                        new DegreeCredit {DegreeCreditId=13, DegreeId=1, CreditId=20},


                };
                Console.WriteLine($"Inserted {degreeCredits.Length} new degree credits.");

                foreach (DegreeCredit d in degreeCredits)
                {
                    context.DegreeCredits.Add(d);
                }
                context.SaveChanges();
            }


          

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exist.");
               
            }
            else
            {
                var degreePlans = new DegreePlan[]
                {
new DegreePlan {DegreePlanId=5431, StudentId=533725, DegreePlanAbbr="Slow and easy", DegreePlanName="Take a break in summer"},
new DegreePlan {DegreePlanId=5432, StudentId=533725, DegreePlanAbbr="Super Fast", DegreePlanName="No break"},
new DegreePlan {DegreePlanId=5433, StudentId=534049, DegreePlanAbbr="Slow and easy", DegreePlanName="As fast as I Can"},
new DegreePlan {DegreePlanId=5434, StudentId=534049, DegreePlanAbbr="Slow and easy", DegreePlanName="Take less courses per semester"},
new DegreePlan {DegreePlanId=5435, StudentId=533767, DegreePlanAbbr="Super Fast", DegreePlanName="More subjects in semesters"},
new DegreePlan {DegreePlanId=5436, StudentId=533767, DegreePlanAbbr="Slow and Consistent", DegreePlanName="Take a break in summer"},
                };
                Console.WriteLine($"Inserted {degreePlans.Length} new Degree Plans.");

                foreach (DegreePlan d in degreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
                
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm {StudentTermId=1, StudentId=533725, Term=1, TermAbbr="F18", TermName="Fall2018"},
                    new StudentTerm {StudentTermId=2, StudentId=533725, Term=2, TermAbbr="s19", TermName="Spring2019"},
                    new StudentTerm {StudentTermId=3, StudentId=533725, Term=3, TermAbbr="Su19", TermName="Summer2019"},
                    new StudentTerm {StudentTermId=4, StudentId=533725, Term=4, TermAbbr="F19", TermName="Fall2019"},
                    new StudentTerm {StudentTermId=5, StudentId=533725, Term=5, TermAbbr="s20", TermName="Spring2020"},
                    new StudentTerm {StudentTermId=6, StudentId=534049, Term=1, TermAbbr="F19", TermName="Fall2019"},
                    new StudentTerm {StudentTermId=7, StudentId=534049, Term=2, TermAbbr="s20", TermName="Spring2020"},
                    new StudentTerm {StudentTermId=8, StudentId=534049, Term=3, TermAbbr="Su20", TermName="Summer2020"},
                    new StudentTerm {StudentTermId=9, StudentId=534049, Term=4, TermAbbr="F20", TermName="Fall2020"},
                    new StudentTerm {StudentTermId=10, StudentId=534049, Term=5, TermAbbr="S21", TermName="Spring2021"},
                    new StudentTerm {StudentTermId=11, StudentId=533767, Term=1, TermAbbr="S19", TermName="Spring2019"},
                    new StudentTerm {StudentTermId=12, StudentId=533767, Term=2, TermAbbr="Su19", TermName="Summer2019"},
                    new StudentTerm {StudentTermId=13, StudentId=533767, Term=3, TermAbbr="F19", TermName="Fall2019"},
                    new StudentTerm {StudentTermId=14, StudentId=533767, Term=4, TermAbbr="S20", TermName="Spring2020"},
                    new StudentTerm {StudentTermId=15, StudentId=533767, Term=5, TermAbbr="Su20", TermName="Summer2020"},


                };
                Console.WriteLine($"Inserted {studentTerms.Length} new student terms.");

                foreach (StudentTerm d in studentTerms)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }



            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist.");
              
            }
            else
            {
                var slots = new Slot[]
                {
                    new Slot {SlotId=1, DegreePlanId=5431, Term=1, CreditId=460, Status="C"},
                    new Slot {SlotId=2, DegreePlanId=5431, Term=1, CreditId=356, Status="C"},
                    new Slot {SlotId=3, DegreePlanId=5431, Term=1, CreditId=563, Status="C"},
                    new Slot {SlotId=4, DegreePlanId=5431, Term=1, CreditId=542, Status="C"},
                    new Slot {SlotId=5, DegreePlanId=5431, Term=2, CreditId=555, Status="A"},
                    new Slot {SlotId=6, DegreePlanId=5431, Term=2, CreditId=560, Status="A"},
                    new Slot {SlotId=7, DegreePlanId=5431, Term=2, CreditId=6, Status="A"},
                    new Slot {SlotId=8, DegreePlanId=5431, Term=3, CreditId=10, Status="-"},
                    new Slot {SlotId=9, DegreePlanId=5431, Term=4, CreditId=691, Status="P"},
                    new Slot {SlotId=10, DegreePlanId=5431, Term=4, CreditId=10, Status="P"},
                    new Slot {SlotId=11, DegreePlanId=5431, Term=5, CreditId=20, Status="P"},
                    new Slot {SlotId=12, DegreePlanId=5431, Term=5, CreditId=692, Status="P"},
                    new Slot {SlotId=13,DegreePlanId=5431,Term=5,CreditId=664,Status="P"},


                };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot d in slots)
                {
                    context.Slots.Add(d);
                }
                context.SaveChanges();
            }

           
           


        }

    }
}
