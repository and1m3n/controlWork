// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.WriteLine("Исходный массив");
string[] str = {"hello", "132", "2", "sell","buy","11"};

void ShowArr(string[] arr){
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+",");
    if(arr[i] == arr[arr.Length-1]){
        Console.Write(arr[i]);
    }
}
}

ShowArr(str);
Console.WriteLine(" ");
Console.WriteLine(" ");


string[] ArrSort(string[] arr){

int lenghtSortArr = 0;
for (int i = 0; i < arr.Length; i++)
{
   if(arr[i].Length <= 3){

lenghtSortArr++;
   }

}
string[] resultArr = new string[lenghtSortArr];
int index = 0;
for (int j = 0; j < arr.Length; j++)
{
   if(arr[j].Length <= 3){

resultArr[index] = arr[j];
index++;
   }
   
} 
return resultArr;
}
//Console.WriteLine("");
Console.WriteLine("Отсортированный массив");
string[] result = ArrSort(str);
ShowArr(result);