using System;
class ComputerPlayer{
  public string ComputerDecision(){
    Random rnd=new Random();
    int rnd_num=rnd.Next(0,3);
    if(rnd_num==0){
      return "rock";
    }
    else if(rnd_num==1){
      return "paper";
    }
    else{
      return "scissors";
    }
  }

}