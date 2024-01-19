int cnt = 0;
int Recurce(int a)
{
    if(a == 0)
    {
        return cnt ;
    }
    else
    {
        cnt++ ;
       return Recurce(a/=10);
        
    }
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Recurce(a));
