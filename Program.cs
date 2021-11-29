
// C# program for the above approach. 
using System;

class GFG
{

    // Function to check 
    // if parentheses are balanced 
    public static bool isBalanced(String exp)
    {

        // Initialising variables 
        bool flag = true;
        int count = 0;

        // Traversing the expression 
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '(')
            {
                count++;
            }
            if(exp[i] == ')')
            {

                // It is a closing parenthesis 
                count--;
            }
            if (count < 0)
            {

                // This means there are 
                // more Closing parenthesis 
                // than opening ones 
                flag = false;
                break;
            }
        }

        // If count is not zero, 
        // It means there are 
        // more opening parenthesis 
        if (count != 0)
        {
            flag = false;
        }
        return flag;
    }

    // Driver code
    public static void Main(String[] args)
    {
        String exp1 = "2x - 3y + 25 / (2+5)*12 - ((29*4-2) + 32) -14";

        if (isBalanced(exp1))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");

        String exp2 = "2x - 3y + 25 / (-((29*4-2) + 32) -14 - (2+5)*12";

        if (isBalanced(exp2))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        String exp3 = "((((((((((((((((((((2x-4y * 98 )))))))))))))))))))))";

        if (isBalanced(exp3))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}

// This code is contributed by Amit Katiyar