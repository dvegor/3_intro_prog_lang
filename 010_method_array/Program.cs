int[] array = {71,92,38,44,35,26,75,48};

int n = array.Length;
int find = 75;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}