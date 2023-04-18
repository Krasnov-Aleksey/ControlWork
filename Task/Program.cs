// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] arr={"Hello", "2", "world", ":-)"};
int numberСhar=3; //длина которых меньше, либо равна 3 символам
Console.WriteLine($"Массив: [{String.Join(", ",arr)}]");
int count=0;
for (int i=0; i<arr.Length;i++) //определяем размер нового массива
{
    if (arr[i].Length<=numberСhar)
    {
        count++;
    }
}

string[] newArr=new string[count];
count=0;
for (int i=0; i<arr.Length;i++) //заносим данны в новый массив
{
    if (arr[i].Length<=numberСhar)
    {
        newArr[count]=arr[i];
        count++;
    }
}
Console.WriteLine($"Новый массив: [{String.Join(", ",newArr)}]");

