Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int[] arrres = new int[];
for (int i = 0; i < n; i++)
 {
    Console.Write("Введите строку" + i+1 + ": ");
    arr[i] = Console.ReadLine();
    if(arr[i].Length <= 3) arrres[] += arr[i];
 }
 Console.WriteLine("[" + string.Join(", ", arr) + "] -> " + "[" + string.Join(", ", arrres) + "]");