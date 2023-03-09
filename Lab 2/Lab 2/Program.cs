using Lab_2;

Organization organization = new Organization();
University university = new University();
Faculty faculty = new Faculty("Information Systems and Technologies", "ISaT", "Cab. 312");

Console.WriteLine(faculty.Name);
Console.WriteLine(faculty.ShortName);
Console.WriteLine(faculty.Address);
Console.WriteLine(faculty.TimeStamp);
Console.WriteLine(faculty.ID);
faculty.PrintInfo();
Console.WriteLine(faculty);
Console.WriteLine(faculty.GetHashCode());
Console.WriteLine(faculty.Equals(faculty));

faculty.OpenJobVacancy(new JobVacancy("DevOps"));
faculty.OpenJobVacancy(new JobVacancy("Frontend developer"));
faculty.CloseJobVacancy(0);
faculty.PrintJobVacancies();
faculty.AddJobTitle(new JobTitle("Frontend developer"));
Console.WriteLine(faculty.GetJobTitles()[0]);
faculty.Recruit(faculty.GetJobVacancies()[0], new Person("Andrey"));
Console.WriteLine(faculty.GetEmployees()[0]);
faculty.Dismiss(0, "Mass layoff");
Console.WriteLine(faculty.GetEmployees().Count);
faculty.DeleteJobTitle(0);
Console.WriteLine(faculty.GetJobTitles().Count);
