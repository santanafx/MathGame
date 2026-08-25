
// You need to create a game that consists of asking the player what's the result of a math question (i.e. 9 x 9 = ?), collecting the input and adding a point in case of a correct answer.


// A game needs to have at least 5 questions.


// The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.


// Users should be presented with a menu to choose an operation


// You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.


// You don't need to record results on a database. Once the program is closed the results will be deleted.

int globalScore = 0;

List<string> history = new List<string>();

string? menuRes = "";

void MathOperation1()
{
  System.Console.WriteLine("Type your answer:");
  string? res1 = Console.ReadLine();

  int.TryParse(res1, out int res1Converted);

  if (res1Converted == 81)
  {
    System.Console.WriteLine("The result 81 is correct");
    history.Add("9 x 9 = 81");
    globalScore++;
  }
  else
  {
    System.Console.WriteLine("The answer is wrong. Try again.");
  }
}
void MathOperation2()
{
  System.Console.WriteLine("Type your answer:");
  string? res2 = Console.ReadLine();

  int.TryParse(res2, out int res2Converted);

  if (res2Converted == 4)
  {
    System.Console.WriteLine("The result 4 is correct");
    history.Add("2 x 2 = 4");
    globalScore++;
  }
  else
  {
    System.Console.WriteLine("The answer is wrong. Try again.");
  }
}
void MathOperation3()
{
  System.Console.WriteLine("Type your answer:");
  string? res3 = Console.ReadLine();

  int.TryParse(res3, out int res3Converted);

  if (res3Converted == 2)
  {
    System.Console.WriteLine("The result 2 is correct");
    history.Add("4 / 2 = 2");
    globalScore++;
  }
  else
  {
    System.Console.WriteLine("The answer is wrong. Try again.");
  }
}
do
{
  System.Console.WriteLine($"Score: {globalScore}");
  System.Console.WriteLine($"History:");
  foreach (string obj in history)
  {
    System.Console.WriteLine(obj);
  }

  System.Console.WriteLine("Choose the desired option to solve");
  System.Console.WriteLine("To close the application type exit and press enter");
  menuRes = Console.ReadLine();

  System.Console.WriteLine("1 - What's the result of 9 x 9 = ?");
  System.Console.WriteLine("2 - What is the result of 2 x 2 = ?");
  System.Console.WriteLine("3 - What is the result of 4 / 2 = ?");
  if (menuRes == "1")
  {
    MathOperation1();
  }
  else if (menuRes == "2")
  {
    MathOperation2();
  }
  else if (menuRes == "3")
  {
    MathOperation3();
  }
} while (menuRes != "exit");
