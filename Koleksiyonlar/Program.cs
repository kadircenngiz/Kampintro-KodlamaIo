using System.Collections.Generic;

//string[] isimler = new string[] { "Ali", "Ayşe", "Fatma", "Mehmet", "Zeynep" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//Console.WriteLine(isimler[4]);


List<string> isimler2 = new List<string> { "kadir", "cengiz", "Cenk", "murat" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);

isimler2.Add("Ali");
Console.WriteLine(isimler2[4]);
