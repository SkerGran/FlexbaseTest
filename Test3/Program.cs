string source = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420";
string[] stringSeparators = new string[] { ", " };
string[] tempResult;
string[] result;

tempResult = source.Split(stringSeparators, StringSplitOptions.None);
result = tempResult;
for (int i = 0; i < tempResult.Length; i++)
{
    int temp = Convert.ToInt32(tempResult[i]);
    if (temp % 3 == 0 && temp % 5 == 0 && temp % 4 == 0 && temp % 7 == 0)
    {
        result[i] = "good-boy-muzz-guzz";
    }
    else if (temp % 3 == 0 && temp % 5 == 0 && temp % 4 == 0)
    {
        result[i] = "good-boy-muzz";
    }
    else if (temp % 3 == 0 && temp % 5 == 0 && temp % 7 == 0)
    {
        result[i] = "good-boy-guzz";
    }
    else if (temp % 3 == 0 && temp % 4 == 0)
    {
        result[i] = "fizz-muzz";
    }
    else if (temp % 3 == 0 && temp % 5 == 0)
    {
        result[i] = "good-boy";
    }
    else if (temp % 3 == 0 && temp % 7 == 0)
    {
        result[i] = "fizz-guzz";
    }
    else if (temp % 4 == 0 && temp % 5 == 0)
    {
        result[i] = "muzz-buzz";
    }
    else if (temp % 4 == 0 && temp % 7 == 0)
    {
        result[i] = "muzz-guzz";
    }
    else if (temp % 5 == 0 && temp % 7 == 0)
    {
        result[i] = "buzz-guzz";
    }
    else if (temp % 4 == 0)
    {
        result[i] = "muzz";
    }
    else if (temp % 7 == 0)
    {
        result[i] = "guzz";
    }
    else if (temp % 3 == 0)
    {
        result[i] = "dog";
    }
    else if (temp % 5 == 0)
    {
        result[i] = "cat";
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
