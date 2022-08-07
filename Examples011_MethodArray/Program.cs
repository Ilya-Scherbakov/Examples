// Имеется массив array из n элементов. Требуется найти эл-т массива, равный find

int[] array = { 12, 42, 32, 84, 51, 66, 57, 81 };
int n = array.Length;
int find = 81;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
