using Lab1.general;
using Lab1;
using System.Diagnostics;




ResearchTeam squad = new ResearchTeam();
Console.WriteLine("1) " +squad.ToShortString());


Console.WriteLine("2) Year: " + squad[TimeFrame.Year]);
Console.WriteLine("Two years: " + squad[TimeFrame.TwoYear]);
Console.WriteLine("Long: " + squad[TimeFrame.Long]);


squad = new ResearchTeam("3) SomeTheme","SomeOrg",1223,TimeFrame.Long);
Console.WriteLine(squad);


squad.AppebdInfo(
    new Info(
        "Info1",
        new Person("A","A",new DateTime(1987,10,11)),
        new DateTime(2012,11,11)),
    new Info(
        "Info2",
         new Person("B","B",new DateTime(2000,9,9)),
         DateTime.Now)    
             );
Console.WriteLine("4) " + squad);


Console.WriteLine("5) " + squad.LastInfo);


Console.WriteLine("6) ");

int width, height;
string[] arr;
do
{
    Console.WriteLine("Enter width and height:  ");
    arr = Console.ReadLine().Split(',');
}
while ((int.TryParse(arr[0], out width) && int.TryParse(arr[1], out height))==false);

Info[] oneArr = new Info[width*height];
for (int i = 0; i < oneArr.Length; i++)
{
    oneArr[i] = new Info();
}


Info[,] twoArr = new Info[width, height];
for (int i = 0; i < width; i++)
{
    for (int j = 0; j < height; j++)
    {
        twoArr[i, j] = new Info();
    }
}

Info[][] caskadArr;
int sum = (width / 2) * (width - 1);
int count = 0;
if(sum < width * height)
{
    caskadArr = new Info[width + 1][];
    for (int i = 0; i <= width; i++)
    {
        count++;
        caskadArr[i] = new Info[count];
        for (int j = 0; j < count; j++)
        {
            caskadArr[i][j] = new Info();
        }
    }
}
else
{
    caskadArr = new Info[width][];
    for (int i = 0; i < width; i++)
    {
        count++;
        caskadArr[i] = new Info[count];
        for (int j = 0; j < count; j++)
        {
            caskadArr[i][j] = new Info();
        }
    }
}

Stopwatch stopwatch = new Stopwatch();


stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i < width; i++)
{
    for (int j = 0; j < height; j++)
    {
        twoArr[i, j].Name = "aaa";
    }
}
stopwatch.Stop();
Console.WriteLine($"TwoArr work: {stopwatch.Elapsed.TotalMilliseconds} ms");

stopwatch.Start();
for (int i = 0; i < oneArr.Length; i++)
{
    oneArr[i].Name = "aaa";
}
stopwatch.Stop();
Console.WriteLine($"OneArr work: {stopwatch.Elapsed.TotalMilliseconds} ms");

stopwatch = new Stopwatch();
stopwatch.Start();
for (int i = 0; i <= caskadArr.Length - 1; i++)
{
    for (int j = 0; j < caskadArr[i].Length; j++)
    {
        caskadArr[i][j].Name = "aaa";
    }
}
stopwatch.Stop();
Console.WriteLine($"CaskadArr work: {stopwatch.Elapsed.TotalMilliseconds} ms");
