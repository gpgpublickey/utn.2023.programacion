// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

unsafe {
    int x = 11;
    int* a = &x;
    Console.WriteLine("{0}", *a);
}

Console.ReadLine();
