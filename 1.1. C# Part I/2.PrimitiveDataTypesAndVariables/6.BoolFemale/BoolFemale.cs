using System;

class BoolFemale
{
    static void Main()
    {
        bool isFemale = false;
        char checkGender;
        Console.WriteLine("If you are a man type \"m\" or if you are a woman type \"f\" ");

        checkGender = (char)Console.Read();
        if (checkGender == 'm')
        {
            Console.WriteLine("Are you a female: {0}", isFemale);
        }
        else
        {
            if (checkGender == 'f')
            {
                Console.WriteLine("Are you a female: {0}", !isFemale);
            }
            else
            {
                Console.WriteLine("You've typed a wrong letter");
            }
        }
    }
}
