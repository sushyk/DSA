// fixed: the Python's print(triangle()) printed a stray "None"
Triangle();

//                *
//             *  *
//          *  *  *
//       *  *  *  *
//    *  *  *  *  *
//  * *  *  *  *  *
static void Triangle()
{
    for (int i = 1; i < 7; i++)
    {
        // print spaces
        int spaces = 6 - i;
        for (int _ = 0; _ < spaces; _++)
        {
            Console.Write("  "); // print(" ", end=" ")
        }

        // print stars
        int stars = i;
        for (int _ = 0; _ < stars; _++)
        {
            Console.Write("* "); // print("*", end=" ")
        }

        // fixed: one line break per row (Python's print("\n") gave a blank line between rows)
        Console.WriteLine();
    }
}
