void Recurce(int a)
{
    if(a == 0)
    {
        return;
    }
    else  
    {
        Recurce(a-1);
        System.Console.Write(a + " ");
      
    }
}

int a = Convert.ToInt32(Console.ReadLine());
Recurce(a);
