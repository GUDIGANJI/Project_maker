using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    public float health;
    public float status;
    public float intelligent;
    public float indurence;
    public float passion;
    public float battlePower;

    public int gold;
    public float tired;

    public SaveData()
    {
        health = 154;
        status = 50;
        intelligent = 50;
        indurence = 50;
        passion = 50;
        battlePower = 50;
        gold = 0;
        tired = 0;
    }
}
