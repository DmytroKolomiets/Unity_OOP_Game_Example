using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgressiveEnemy : Decision // Inherits  myDecision , myList, Wait, Player
{
    public Attack Attack;
    public Run Run;
    Transform TargetRunFrom;
    public override void myDecision()
    {
        //AgressiveEnemy Attacks if The player if is near
        //AgressiveEnemy run away if BigEnemy or SmallEnemy is near
        if (myList.Contains("BigEnemy") || myList.Contains("SmallEnemy"))
        {
            Attack.act = false;
            Run.run(TargetRunFrom.transform, 1.5f, true);
            Wait(2, myDecision);
        }
        else if (myList.Contains("Player"))
        {
            Run.act = false;         
            Attack.attack(Player.transform, 1.5f, true);
            Wait(2, myDecision);
        }
        
        else
        {
            Run.act = false;
            Attack.act = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        TargetRunFrom = other.gameObject.transform;
    }
}
