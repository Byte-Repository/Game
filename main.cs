using System;

class MainClass {
  public static void Main (string[] args) {
    
    HumanPlayer h1=new HumanPlayer(initial:5);

    ComputerPlayer c1=new ComputerPlayer();

    Console.WriteLine("****Rock Paper Scissors, Start!****");
    while(true){
      Console.WriteLine($"You have {h1.GetPoints()} points");
      Console.WriteLine($"Please input your choice: rock, paper, or scissors");
      string h1_decision=h1.HumanDecision();
      string c1_decision=c1.ComputerDecision();
      Console.WriteLine($"--> Your Decision: {h1_decision}");
      Console.WriteLine($"--> Computer Decision: {c1_decision}");
    if(h1_decision==c1_decision){
      Console.WriteLine("It's a tie!");
    }
    else if(h1_decision=="rock"&&c1_decision=="scissors"){
      Console.WriteLine("You win!");
      h1.WinRound();
    }
    else if(h1_decision=="paper"&&c1_decision=="rock"){
      Console.WriteLine("You win!");
      h1.WinRound();
    }
    else if(h1_decision=="scissors"&&c1_decision=="paper"){
      Console.WriteLine("You win!");
      h1.WinRound();
    }
    else{
      Console.WriteLine("You lose");
      h1.LoseRound();
    }
    if(h1.GetPoints()<=0){
      Console.WriteLine("You have ran out of points, game over");
      break;
    }

    Console.WriteLine("Play again? Input y to continue or n to exit");
    string next=Console.ReadLine();
    if(next=="y"){
      continue;
    }
    else if(next=="n"){
      break;
    }
    else{
      Console.WriteLine("Invalid input, exit the game");
      break;
    }

    }
    Console.WriteLine("Thank you for playing!");
  }
}