// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

string[] words = { "Ayna","Kelime" };

ArrayList arrayList = new ArrayList();
arrayList.Add("Türkay");//boxing
arrayList.Add(45);
arrayList.Add(true);

int value = (int)arrayList[0]; //unboxing

List<string> names = new List<string>();
names.Add("Selçuk");
names.Add("Aysun");

foreach (var item in names)
{
    
}

