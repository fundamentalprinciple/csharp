string[] array1 = new string[9];
array1[0]="hello";
array1[1]="world";
array1[2]="bye";
array1[3]="world";
array1[4]="good morning";
array1[5]="world";

foreach(string greeting in array1) {
    Console.WriteLine(greeting);
}

Console.WriteLine("the end");
