
//int n = int.Parse(Console.ReadLine());
//int[] mult = new int[]
//for (int i = 1; i <=n; i++)
//{
//    string num = i +"";
//    string mul = i*i +"";
//    string num2 = null;
//    for (int f = 0; f < mul.Length; f++)
//    {
//        num2 += num[f];
//    }
//}




int n = int.Parse(Console.ReadLine());
int[] mult = new int[n];
int i = 1;
int points = 0;
while (mult[n - 1] == 0)
{

    string num = i + "";
    string num2 = i * i + "";
    string num3 = null;
    for (int f = 0; f < num.Length; f++)
    {
        try
        {
            num3 += num2[f + 1];
        }
        catch
        {
            num3 += num2[f];
        }
    }
    if (num3 == num)
    {
        mult[points] = i; points++;
    }
    i++;


}
for (int t = 0; t < mult.Length; t++)
{
    Console.WriteLine(mult[t]);
}