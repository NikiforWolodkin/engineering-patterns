using Lec04LibN;

ILogger logger1 = Logger.Create();
logger1.Log("0");
logger1.Log("1");
logger1.Start("A");
logger1.Log("2");
logger1.Start("B");
logger1.Log("3");
logger1.Stop();
logger1.Log("4");

ILogger logger2 = Logger.Create();
logger2.Log("5");
logger2.Start("C");
logger2.Log("6");
logger2.Start("D");
logger2.Log("7");
logger2.Log("8");
logger2.Stop();
logger2.Log("9");
logger2.Log("10");
logger2.Log("11");
logger2.Stop();

ILogger logger3 = Logger.Create();
logger3.Log("12");
logger3.Start("E");
logger3.Start("F");
logger3.Stop();
logger3.Stop();

var logs = Directory
    .GetFiles("../../../")
    .Where(log => log.Contains("LOG"))
    .OrderByDescending(log => log)
    .ToList();

Console.WriteLine(logs[0]);
Console.WriteLine(File.ReadAllText(logs[0]));