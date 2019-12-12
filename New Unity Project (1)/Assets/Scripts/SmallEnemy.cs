using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : Decision  // Inherits myDecision, myList, Wait, Player
{   
    public Attack Attack;
    public Run Run;   
    public override void myDecision()
    {
              // SmallEnemy Run away if The player is near
              // SmallEnemy Attack if The player is near and a wall or BigEnemy also is near
        if ((myList.Contains("Player") && myList.Contains("BigEnemy")) ||( myList.Contains("Wall") && myList.Contains("Player")))
        {
            Run.act = false;           
            Attack.attack(Player.transform, 1.5f,true);              
            Wait(2, myDecision);
        }
        else if (myList.Contains("Player"))
        {          
            Attack.act = false;
            Run.run(Player.transform, 1.5f, true);
            Wait(2, myDecision);
        }
        else
        {
            Run.act = false;
            Attack.act = false;
        }

    }
           
}
