// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Dan!");

Console.WriteLine("C# Developer");

int day=09;

string name ="Dan";

Console.WriteLine("Today is day "+day+name +"You did it");
// string sent = "i am okay";
// Console.WriteLine(sent.Count());


int test=9;

test++;

Console.WriteLine(test);

int tset= Convert.ToInt32( Console.ReadLine());


string[] ar={"ghj","dfg","rtyu"};

Console.WriteLine(ar[0]);


Console.WriteLine(ar.Length);


Console.WriteLine(tset);



static int calc(int numb,int numb2,int numb3)
{
    int sum1=numb+numb2;
    int sum2=numb+numb3;

    if (numb<numb3)
    {
        return sum1;
    }
    else
    {
        return sum2;
    }
}


Console.WriteLine(calc(70890,9,10));

Console.ReadLine();



