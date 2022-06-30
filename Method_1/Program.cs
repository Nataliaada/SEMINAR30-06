// Вид 1. Ничего не принимает ничего не возвращает

// void Method1()
// {
// Console.WriteLine("Автор");
// }
// Method1();

// Вид 2. Ничего не  возвращает, что-то принимает 
// void Method2(String msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//    int i = 0;
// while (i < count)
//    {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// // Method21("Текст", 4);
// // // Именнованные аргументы тоже можно использовать в любом порядке
// // Method21(msg: "Текст", count: 4);

// //Вид 3 Ничего не принимае. но  возвращает
//  int Method3()
//  {
//     return  DateTime.Now.Year;
//  }
//   int Year = Method3();
//   Console.WriteLine(Year);


// Вид 4 Возвращем строку н раз Может принимать и вовзращать

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
   
//     while (i < count)
//     { 
//       result = result + text;
//      i++;
//     }
//    return result;
// // }
// // string res = Method4(10, "z");
// // Console.WriteLine(res);


// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//    for (int i = 0; i < count; i++)
    
//     { 
//       result = result + text;
     
//     }
//    return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i <=10; i++)
// {
//   for (int j = 2; j <=10; j++)  
//   {
//    Console.WriteLine($"{i} x {j} = { i*j}");
//   }
// }


// for (int i = 2; i <=10; i++)
// {
//   for (int j = 2; j <=10; j++)  
//   {
//    Console.WriteLine($"{i} x {j} = { i*j}");
//   }
//   Console.WriteLine();
// }


// string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали"
// +" вместо нашего милого Винценгероде, вы бы взяли приступом согласие"
// +"прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
// {
//     if (text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// newText = Replace(text, 'к', 'K');
// Console.WriteLine(newText);

// newText = Replace(text, 'к', 'K');
// Console.WriteLine(newText);


// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);

// int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for ( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
// Console.WriteLine();
// }
// // PrintArray(arr);

// void SelectionSort(int[] array)
// {

// for (int i = 0; i < array.Length - 1; i++)
// {

// int minPosition = i;
// for (int j = i + 1; j < array.Length; j++)
// {

// if (array[j] < array[minPosition])
// {
// minPosition = j;
// }
// }

// int temporary = array[i]; 
// array[i] = array[minPosition];
// array[minPosition] = temporary;
// }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
Console.WriteLine();
}
// PrintArray(arr);

void SelectionSort(int[] array)
{

for (int i = 0; i < array.Length - 1; i++)
{

int maxPosition = i;
for (int j = i + 1; j < array.Length; j++)
{

if (array[j] > array[maxPosition])
{
maxPosition = j;
}
}

int temporary = array[i]; 
array[i] = array[maxPosition];
array[maxPosition] = temporary;
}
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);