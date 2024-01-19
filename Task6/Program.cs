int a = 1, b = 20;

void RecurceEven(int a, int b)
{
    if (a % 2 == 0)
    {
        if (a > b)
        {
            return;
        }


        else
        {
            System.Console.Write(a + " ");
            RecurceEven(a + 2, b);
        }

    }
    else
    {
        if (a > b)
        {
            return;
        }


        else
        {
            RecurceEven(a + 1, b);
        }

    }

}



void RecurceOdd(int a, int b)
{
    if (a % 2 != 0)
    {
        if (a > b)
        {
            return;
        }


        else
        {
            System.Console.Write(a + " ");
            RecurceOdd(a + 2, b);
        }

    }
    else 
    {
        if (a > b)
        {
            return;
        }


        else
        {
            RecurceOdd(a + 1, b);
        }

    }
}

System.Console.WriteLine("All even numbers from 1 to 20 are :");
RecurceEven(a, b);

System.Console.WriteLine();

System.Console.WriteLine("All odd numbers from 1 to 20 are :");
RecurceOdd(a, b);
