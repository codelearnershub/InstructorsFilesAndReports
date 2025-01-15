
// Lecture Examples For Nested Loop

//Example (1)

/*Write a csharp program to print a triangle with numbers. collect the numbers of rows of the Triangle from the user.
Use Nested Loop for the solution.
Output:
1
2 2
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
8 8 8 8 8 8 8 8*/

//Code Solution
Console.Write("Enter the number of rows for the triangle: ");
int rows = int.Parse(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
//Example (2)

/*Write a csharp program to print a triangle with numbers. collect the numbers of rows of the Triangle from the user.
Use Nested Loop for the solution.
Output:
1 2 3 4 5 6 7 8
1 2 3 4 5 6 7
1 2 3 4 5 6
1 2 3 4 5
1 2 3 4
1 2 3
1 2
1
*/

//Code Solution
PrintTrangle();
static void PrintTrangle()
{
    Console.Write("Enter the number of rows for the triangle: ");
    int rows = int.Parse(Console.ReadLine());

    for (int i = rows; i >= 1; i--)
    {
        
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }

        Console.WriteLine();
    }
}

//Example (3)

/*Write a csharp program to print a multiplication symbol. collect the numbers of rows of the multiplication symbol from the user.
Use Nested Loop for the solution.
Output:
*             *
  *         *
    *     *
      * *
      * *
    *     *
  *         *
*             *
*/

//Code Solution

PrintMultiplicationSymbol();
static void PrintMultiplicationSymbol()
{
    Console.Write("Enter the number of rows for the multiplication symbol: ");
    int rows = int.Parse(Console.ReadLine());
    for (int i = 1; i <= rows; i++)
    {
        for (int j = 1; j <= rows; j++)
        {
            if (j == i || j == (rows - i + 1))
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }
}

//Example (4)

/*Write a csharp program to print a pyramid. collect the numbers of rows of the pyramid from the user.
Use Nested Loop for the solution.
Output:
*
* *
*   *
*     *
*       *
*         *
*           *
*             *
*               *
*                 *
*                   *
* * * * * * * * * * * *
*/

//Code Solution
PrintPyramid();
static void PrintPyramid()
{
    Console.Write("Enter the number of rows for the pyramid: ");
    int rows = int.Parse(Console.ReadLine());
    for (int i = 1; i <= rows; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j == 1 || j == i || i == rows)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }



    //Class Work (1)

    /*Write a csharp program to print a triangle. collect the numbers of rows of the Triangle from the user.
    Use Nested Loop for the solution.
    Output:
           1
          2 2
         3 3 3
        4 4 4 4
       5 5 5 5 5
      6 6 6 6 6 6
     7 7 7 7 7 7 7
    8 8 8 8 8 8 8 8
    */

    //Code Solution

    PrintTriangle();
    static void PrintTriangle()
    {
        Console.Write("Enter the number of rows for the triangle: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // Move to the next line after each row
        }
    }

    //Class Work (2)

    /*Write a csharp program to print a square. collect the numbers of rows of the square from the user.
    Use Nested Loop for the solution.
    Output:
    1 1 1 1 1 1 1 1 1
    2 2 2 2 2 2 2 2 2
    3 3 3 3 3 3 3 3 3
    4 4 4 4 4 4 4 4 4
    5 5 5 5 5 5 5 5 5
    6 6 6 6 6 6 6 6 6
    7 7 7 7 7 7 7 7 7
    8 8 8 8 8 8 8 8 8
    9 9 9 9 9 9 9 9 9
    */

    //Code Solution
    Console.Write("Enter the number of rows for the square: ");
    int rows1 = int.Parse(Console.ReadLine());

    for (int i = 1; i <= rows1; i++)
    {
        for (int j = 1; j <= rows1; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    //note detailed explanation of how the process works is provided for each of examples
    //and classwork given in class


    //material source for the examples

    //1 internet.
    //2 Fundamentals - of - Computer - Programming - with - CSharp - Nakov - eBook - v2013.pdf.
    //3 Udemy Material.