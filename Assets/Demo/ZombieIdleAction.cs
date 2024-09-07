using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityAI;

public class ZombieIdleAction : Action<Zombie>
{
    public override void Execute(Zombie context) {
        Debug.Log("Idle");
    }

    public override void Stop(Zombie context) {
    }
}
