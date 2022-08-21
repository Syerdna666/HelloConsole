int[] array = { 13, 22, 28, 24, 53, 61, 73, 28 };

int n = array.Length;
int find = 28;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}