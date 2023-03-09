using Lab_3;
using Lec03BLibN;

Console.WriteLine("--- Laboratory work 3 ---\n");

IFactory l1 = Lec03BLib.GetL1();

Employee employee1 = new Employee(l1.GetA(25));
Console.WriteLine($"Bonus-L1-A = {employee1.CalculateBonus(4)}");

Employee employee2 = new Employee(l1.GetB(25, 1.1f));
Console.WriteLine($"Bonus-L1-B = {employee2.CalculateBonus(4)}");

Employee employee3 = new Employee(l1.GetC(25, 1.1f, 5.0f));
Console.WriteLine($"Bonus-L1-C = {employee3.CalculateBonus(4)}");

IFactory l2 = Lec03BLib.GetL2(1);

Employee employee4 = new Employee(l2.GetA(25));
Console.WriteLine($"Bonus-L2-A = {employee4.CalculateBonus(4)}");

Employee employee5 = new Employee(l2.GetB(25, 1.1f));
Console.WriteLine($"Bonus-L2-B = {employee5.CalculateBonus(4)}");

Employee employee6 = new Employee(l2.GetC(25, 1.1f, 5.0f));
Console.WriteLine($"Bonus-L2-C = {employee6.CalculateBonus(4)}");

IFactory l3 = Lec03BLib.GetL3(1, 0.5f);

Employee employee7 = new Employee(l3.GetA(25));
Console.WriteLine($"Bonus-L3-A = {employee7.CalculateBonus(4)}");

Employee employee8 = new Employee(l3.GetB(25, 1.1f));
Console.WriteLine($"Bonus-L3-B = {employee8.CalculateBonus(4)}");

Employee employee9 = new Employee(l3.GetC(25, 1.1f, 0.5f));
Console.WriteLine($"Bonus-L3-C = {employee9.CalculateBonus(4)}");