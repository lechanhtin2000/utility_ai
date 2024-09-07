using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityAI;

public class ZombieHpScore : ContextualScorer<Zombie>
{
    protected override float RawScore(Zombie context)
    {
        return (context.currentHp == 0) ? 1 : 0;// /(float) context.MaxHp;
    }
}
