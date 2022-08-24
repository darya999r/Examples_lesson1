// int [] array = {48, 34, 28, 14, 69, 42, 52, 92, 21};

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result;
// }

// int max = Max(Max(array[0],array[1],array[2]),
//             Max(array[3],array[4],array[5]),
//             Max(array[6],array[7],array[8]));

// Console.WriteLine(max);


//2
int[] array = {3, 21, 76, 34, 5, 75, 1, 75};

int n = array.Length;

int find = 75;

int index = 0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

