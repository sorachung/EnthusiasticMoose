using System;
using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    List<string> canadaQuestion = new List<string> { "Is Cananda real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!" };
    List<string> enthusiasticQuestion = new List<string> { "Are you enthusiastic?", "Yay!", "You should try it!" };
    List<string> loveCSharpQuestion = new List<string> { "Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will..." };
    List<string> secretQuestion = new List<string> { "Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!" };

    List<List<string>> questions = new List<List<string>>()
    {
        canadaQuestion,
        enthusiasticQuestion,
        loveCSharpQuestion,
        secretQuestion
    };

    foreach (List<string> question in questions)
    {
        Question(question[0], question[1], question[2]);
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void Question(string question, string yesAnswer, string noAnswer)
{
    bool isYes = MooseAsks(question);
    if (isYes)
    {
        MooseSays(yesAnswer);
    }
    else
    {
        MooseSays(noAnswer);
    }
}