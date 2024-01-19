void Recurce(int a)
{
    if(a == 0)
    {
        return ;
    }
    else
    {
        Recurce(a/10);
        System.Console.Write(a%10 + " ");
    }
}

int a = Convert.ToInt32(Console.ReadLine());
Recurce(a);
