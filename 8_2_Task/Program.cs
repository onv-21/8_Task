using System.IO;
using System.Text;
StreamWriter f1 = new StreamWriter("D:\\f1.txt");
Random r = new Random();
for (int i = 0; i < 10; i++) f1.WriteLine(r.Next(0, 100));
f1.Close();
StreamReader f = new StreamReader("D:\\f1.txt");
string s = "";
int[] array = new int [10];
int Sum = 0;
for (int i = 0; i < 10; i++)
{
    array[i] = Int32.Parse(f.ReadLine());
    Sum += array[i];
}
f.Close();
Console.WriteLine(Sum);