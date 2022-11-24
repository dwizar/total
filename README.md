# Итоговая проверочная работа

## Содержание
* Задача
* Описание алгоритма
* Код на C#

## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполения аглоритма.


## Описание алгоритма

Инициализируем переменные: исходный массив arr[], размерность массива N, итерационный счетчик i, результирующий массив arrres[]. Запрашиваем ввод размерности массива, и заполняем массив строками, введенными с клавиатуры в цикле от 0 до N. В этом же цикле делаем проверку свойства длины строки для каждого элемента. Если длина строки меньше либа равна 3, то записываем элемент также в результирующий массив. По окончании цикла выводим на экран исходный и результирующий массив.


## Код на C#

```
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[n];
string[] arrres = new string[n];
int j = 0;
for (int i = 0; i < n; i++)
 {
    int str = i + 1;
    Console.Write("Введите строку " + str + ": ");
    arr[i] = Console.ReadLine();
    if(arr[i].Length <= 3) 
     {
      arrres[j] += arr[i];
      j++;
     }
 }
 Array.Resize(ref arrres, j);
 Console.WriteLine("[" + string.Join(", ", arr) + "] -> " + "[" + string.Join(", ", arrres) + "]");
```

