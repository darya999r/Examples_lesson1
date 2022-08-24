int a1 = 48;
int b1 = 34;
int c1 = 28;
int a2 = 14;
int b2 = 69;
int c2 = 42;
int a3 = 52;
int b3 = 92;
int c3 = 21;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(max);
