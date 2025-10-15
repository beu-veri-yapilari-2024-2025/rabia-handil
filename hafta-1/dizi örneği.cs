int[,] numbers = { { 1, 3, 5 }, { 4, 5, 3 }, { 5, 2, 7 }, { 4, 12, 104 } };
    
int ek= numbers [0,0];
for (int i = 0;i< numbers.GetLength(0);i++)
{
    for (int j = 0;j< numbers.GetLength(1);j++)
    {
        if (numbers[i,j]<ek)
        {
            ek = numbers[i,j];

    
        }
    }
}
Console.Write("dizideki en küçük sayı{0}", ek);
