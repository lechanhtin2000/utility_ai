using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityAI;

public class ZombieIdleScore : ContextualScorer<Zombie>
{
    public float score;
    protected override float RawScore(Zombie context) {
        return score;
    }
}
