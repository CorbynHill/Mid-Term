using System.Diagnostics;
using System.Dynamic;

Console.WriteLine("Choose what category you want to play in: 1-Food 2-Animals 3-Movies ");
string falCategory = Console.ReadLine();
int Category = Convert.ToInt32(falCategory);
bool game = true;
if (Category == 1) //FOOD
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("You chose Foods!");

    string[] listFood = { "lasagna", "sandwich", "spaghetti", "burrito", "omelette", "pancakes", "stew", "tacos", "casserole", "sushi" };
    Random random = new Random();
    int randomIndex = random.Next(listFood.Length);
    string randomWord = listFood[randomIndex];

    string word = randomWord;
    char[] display = new string('_', word.Length).ToCharArray();
    int attempts = 999;
    int tries = 0;

    while (attempts > 0)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Attempts left: " + attempts);
        Console.Write("Guess the word!");
        Console.WriteLine(display);

        Console.Write("Enter a letter: ");
        char guess = Console.ReadLine()[0];


        for (int letters = 0; letters < word.Length; letters++)
        {
            if (word[letters] == guess)
            {
                display[letters] = guess;
            }
        }

        attempts -= 1;
        Console.WriteLine(display);

        tries += 1;
        Console.WriteLine("Tries: " + tries);

        if (new string(display) == word)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("You have guessed the correct word!: " + word);
            Console.WriteLine("In " + tries + " attempts");
            attempts = 0;
            Category = -987;
        }
        if (attempts == 0)
        {
            game = false;
        }

    }
}

if (Category == 2) //ANIMALS
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("You chose Animals!");

    string[] listAnimal = { "tiger", "zebra", "rabbit", "giraffe", "dolphin", "kangaroo", "penguin", "cheetah", "leopard", "buffalo" };
    Random random = new Random();
    int randomIndex = random.Next(listAnimal.Length);
    string randomWord = listAnimal[randomIndex];

    string word = randomWord;
    char[] display = new string('_', word.Length).ToCharArray();
    int attempts = 999;
    int tries = 0;

    while (attempts > 0)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Attempts left: " + attempts);
        Console.Write("Guess the word!");
        Console.WriteLine(display);

        Console.Write("Enter a letter: ");
        char guess = Console.ReadLine()[0];


        for (int letters = 0; letters < word.Length; letters++)
        {
            if (word[letters] == guess)
            {
                display[letters] = guess;
            }
        }

        attempts -= 1;
        Console.WriteLine(display);

        tries += 1;
        Console.WriteLine("Tries: " + tries);


        if (new string(display) == word)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("You have guessed the correct word!: " + word);
            Console.WriteLine("In " + tries + " attempts");
            attempts = 0;
            Category = -987;
        }
        if (attempts == 0)
        {
            game = false;
        }

    }
}

if (Category == 3) //MOVIE
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("You chose Movies!");

    string[] listMovie = { "inception", "gladiator", "avatar", "titanic", "interstellar", "goodfellas", "frozen", "coco", "avengers", "shrek" };
    Random random = new Random();
    int randomIndex = random.Next(listMovie.Length);
    string randomWord = listMovie[randomIndex];

    string word = randomWord;
    char[] display = new string('_', word.Length).ToCharArray();
    int attempts = 999;
    int tries = 0;

    while (attempts > 0)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Attempts left: " + attempts);
        Console.Write("Guess the word!");
        Console.WriteLine(display);

        Console.Write("Enter a letter: ");
        char guess = Console.ReadLine()[0];


        for (int letters = 0; letters < word.Length; letters++)
        {
            if (word[letters] == guess)
            {
                display[letters] = guess;
            }
        }

        attempts -= 1;
        Console.WriteLine(display);

        tries += 1;
        Console.WriteLine("Tries: " + tries);


        if (new string(display) == word)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("You have guessed the correct word!: " + word);
            Console.WriteLine("In " + tries + " attempts");
            attempts = 0;
            Category = -987;
        }
        if (attempts == 0)
        {
            game = false;
        }

    }
}


//incorrect category
if (Category > 3)
{
    Console.WriteLine("-ERROR--CATEGORY DOES NOT EXIST-");
}
//incorrect category
if (Category == 0)
{
    Console.WriteLine("-ERROR--CATEGORY DOES NOT EXIST-");

}
if (game == false)
{
    Console.WriteLine("GAME OVER!");
}
if (Category == -987)
{
    Console.WriteLine("");
}