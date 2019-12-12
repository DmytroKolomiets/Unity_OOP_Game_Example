using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : Decision // Inherits myDecision, myList, Wait, Player
{
    public Attack Attack;
    public Run Run;
    public override void myDecision()
    {
        //BigEnemy run away if the Player is near
        //BigEnemy attacks if the Player and a Wall is near
        if (myList.Contains("Player") &&  myList.Contains("Wall"))
        {
            Run.act = false;          
            Attack.attack(Player.transform, 1.2f, true);
            Wait(2, myDecision);
        }
        else if (myList.Contains("Player"))
        {
           
            Attack.act = false;
            Run.run(Player.transform, 1.2f, true);
            Wait(2, myDecision);
        }
        else
        {
            Run.act = false;
            Attack.act = false;
        }

    }
}
