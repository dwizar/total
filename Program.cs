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
      arrres[j] = arr[i];
      j++;
     }
 }
 Array.Resize(ref arrres, j);
 Console.WriteLine("[" + string.Join(", ", arr) + "] -> " + "[" + string.Join(", ", arrres) + "]");