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
    while (i < count)
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

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

//Call the method:
// string res = Method4(10, "abcdf");
// Console.WriteLine(res);


//Пример задачи
//Дан текст. В тексте надо все пробелы заменить черточками, 
//маленькие буквы "k" - большими "K", большие буквы "M" - маленькими "m".

string text = "Meet my family. "
            + "There are five of us – my parents, "
            + "my elder brother, my baby sister and me. "
            + "First, meet my mum and dad, Jane and Michael. "
            + "My mum enjoys reading and my dad enjoys playing "
            + "chess with my brother Ken. My mum is slim and rather tall.";

//string s = "gwerty"
//            0123...
//s[3] -> r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        
    }
    return result;
}

string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
string newText1 = Replace(newText, 'k', 'K');
// Console.WriteLine(newText1);
// Console.WriteLine();
string newText2 = Replace(newText1, 'M', 'm');
Console.WriteLine(newText2);
