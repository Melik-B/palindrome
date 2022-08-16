//palindrome

//ALGORITHM

//1.2 Start.
//1.2 User can login again and again until they press the letter 'q', when they press the letter 'q' they exit the application.
//1.3 User input must be at least two characters.
//1.4 The user does not have to enter only letters.
//1.5 If the word entered by the user is a palindrome, 'The word you entered is a palindrome'. Otherwise, 'The word you entered is not a palindrome.' written.


//palindrom

//ALGORİTMA

//1.2 Başla.
//1.2 Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
//1.3 Kullanıcının yaptığı giriş en az iki karakter olmalıdır.
//1.4 Kullanıcı sadece harf girecek diye bir zorunluluk yoktur.
//1.5 Eğer kullanıcının girdiği kelime palindrom ise ekrana 'Girdiğiniz kelime palindromdur.', değilse 'Girdiğiniz kelime palindrom değildir.' yazılır.



using palindrome;

Logo.WriteLogo();

Console.Write("Enter a word (Exit => q): ");
string word = Console.ReadLine();

while (word != "q") //Another method(Diğer Yöntem) => if(word != "q")
{

    if (word.Length > 2)
    {
        #region How to do without using methods
        //string result = "";
        //for (int i = word.Length - 1; i >= 0; i--)
        //{
        //    result += word[i];
        //}
        #endregion

        string reverseWord = reverse(word);

        if (reverseWord == word) //Another method(Diğer Yöntem) => if(result == word) -- if we didn't use method
        {
            Console.WriteLine("Reverse: " + reverseWord); //Another method(Diğer Yöntem) => Console.WriteLine("Reverse: " + result); -- if we didn't use method
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Entered Word Palindrome.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Reverse: " + reverseWord); //Another method(Diğer Yöntem) => Console.WriteLine("Reverse: " + result); -- if we didn't use method
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The entered word is not a palindrome.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.Write("\nThe entered word must be longer than 2 characters!\n");
    }

    Console.Write("\nEnter a word: ");
    word = Console.ReadLine();
}

static string reverse(string value)
{
    string result = "";
    for (int i = value.Length - 1; i >= 0; i--)
    {
        result += value[i];
    }
    return result;
}