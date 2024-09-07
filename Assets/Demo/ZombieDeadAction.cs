using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityAI;

public class ZombieDeadAction : Action<Zombie>
{
    public override void Execute(Zombie context)
    {
        Debug.Log("Zombie dead");
    }

    public override void Stop(Zombie context)
    {
        Debug.Log("Zombie end dead");
    }
}
