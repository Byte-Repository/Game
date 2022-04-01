using System;
class HumanPlayer{
  private int points;
  public HumanPlayer(int initial){
    points=initial;
  }
  public int GetPoints(){
    return points;
  }
  public void WinRound(){
    points+=5;
  }
  public void LoseRound(){
    points-=5;
  }
  public string HumanDecision(){
    string input= Console.ReadLine();
    return input;
  }
}