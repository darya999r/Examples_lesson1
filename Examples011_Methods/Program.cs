//Type 1

void Method1()
{
    Console.WriteLine("author: ");
}

//Call the method: 
//Method1();

//Type 2a

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Call the method:
//Method2(msg: "text");
//or
//Method2("text");

//Type 2b

void Method2b(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Call the method:
//Method2b("text",4);
//or
//Method2b(msg:"text", count:4);

//Type 3

int Method3()
{
    return DateTime.Now.Year;
}

//Call the method:
// int year = Method3();
// Console.WriteLine(year);


//Type 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    
    while(i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}

//Call the method:
// string res = Method4(10, "abcdf");
// Console.WriteLine(res);
