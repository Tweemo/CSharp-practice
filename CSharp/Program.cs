// See https://aka.ms/new-console-template for more information

// GUESSING GAME

//string secretWord = "giraffe";
//string guess = "";
//int guessCount = 0;
//int guessLimit = 3;
//bool outOfGuesses = false;

//while (guess != secretWord && !outOfGuesses)
//{
//    if (guessCount < guessLimit)
//    {
//    Console.Write("Enter your guess: ");
//    guess = Console.ReadLine();
//    guessCount++;
//    } else
//    {
//       outOfGuesses = true;
//    }
//};

//if(outOfGuesses == true)
//{
//    Console.Write("You Lose!");
//} else
//{
//    Console.Write("You Win!");
//}

//-----------------------------

//Power Func

//static int GetPow(int baseNum, int powNum)
//{
//    int result = 1;

//    for(int i = 0; i < powNum; i++)
//    {
//        result = result * baseNum;
//    }
//    return result;
//};


//Console.WriteLine(GetPow(5, 5));

//-----------------------------


//Exception HANDLING

//try
//{

//    Console.Write("Enter a number: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Enter another number: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(num1 / num2);
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (FormatException e)
//{
//    Console.WriteLine("Try using numbers only silly");
//}

//Console.ReadLine();

// Classes

using CSharp;

Book book1 = new Book("Harry Potter", "JK Rowling", 400);
Book book2 = new Book("Lord of the Rings", "Tolkien", 234);

Console.WriteLine(book1.title);
Console.WriteLine(book2.title);

Student student1 = new Student("Jim", "Business", 2.3);
Student student2 = new Student("Pam", "Design", 4.3);

Console.WriteLine(student1.HasHonours());
Console.WriteLine(student2.HasHonours());
