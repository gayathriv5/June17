string[] trainees = new string[]
{
   "akhil","madhav","raachell"
};

Console.WriteLine(trainees[0]);


for(int i = 0; i < trainees.Length; i++)
{
    Console.WriteLine(trainees[i]);
}
Console.WriteLine();    
Console.WriteLine("For Each");

foreach (string trainee in trainees)
{
    Console.WriteLine(trainee);
}
