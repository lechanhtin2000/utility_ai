using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilityAI;

public class Zombie : MonoBehaviour , IAIContext , IAIContextProvider
{
    public int MaxHp = 100;
    public int currentHp;
    public Brain brain;

    AI ai;

    void Awake()
    {
        ai = new AI(brain);

    }

    public IAIContext GetContext()
    {
        return this;
    }

    public void OnEnable() {
        currentHp = MaxHp;
    }

    public void UpdateContext()
    {
    }

    void Update() {
        UpdateContext();
        ai.Process(this);
    }
}
