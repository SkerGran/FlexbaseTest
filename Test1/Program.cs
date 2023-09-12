string source = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15";
string[] stringSeparators = new string[] { ", " };
string[] tempResult;
string[] result;

tempResult = source.Split(stringSeparators, StringSplitOptions.None);
result = tempResult;
for (int i = 0; i < tempResult.Length; i++)
{
    int temp = Convert.ToInt32(tempResult[i]);
    if (temp % 3 == 0 && temp % 5 == 0)
    {
        result[i] = "fizz-buzz";
    }
    else
    if (temp % 3 == 0)
    {
        result[i] = "fizz";
    }
    else
    if (temp % 5 == 0)
    {
        result[i] = "buzz";
    }
    else result[i] = tempResult[i];
}
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i]);
    if (i < tempResult.Length - 1)
    {
        Console.Write(", ");
    }
}
