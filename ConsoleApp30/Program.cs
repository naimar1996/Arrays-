//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//int[] arr = { 12, 34, 45, 56 };
//int sum = 0;
//int average = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//    average = sum / arr.Length;
//}
//Console.WriteLine(average);

//int[] logo = { 72,60,48,36,24,12 };
//int temp; 
//for (int i = 0; i < logo.Length; i++)
//{
//    for (int y = i + 1; y < logo.Length; y++)
//    {
//        if (logo[i] > logo[y])
//        {
//            temp = logo[i];
//            logo[i] = logo[y];
//            logo[y] = temp;
//        }
//    }

//Console.WriteLine(logo[i]);
//}

int[] fast = { 12, 24, 36, 48, 60, 72 };
int slow;
for (int k = 0; k < fast.Length; k++)
{
    for (int c = k + 1; c < fast.Length; c++)
    {
        if (fast[k] < fast[c])
        {
            slow = fast[k];
            fast[k] = fast[c];
            fast[c] = slow;


        }
    }
    Console.WriteLine(fast[k]);

}