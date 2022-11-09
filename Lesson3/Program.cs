//int[] a = {120, 50, 45, 85};

//for(int i = 0; i < a.Length; i++)
//{
  //  Console.WriteLine(a[i]);
//}


int[] a = new int[8];  //рендомный массив
 for(int i = 0; i < a.Length; i++)
 {
    a[i] = new Random().Next(2, 4);
    Console.Write(a[i] + " ");
 } 