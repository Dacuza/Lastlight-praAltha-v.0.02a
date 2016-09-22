using UnityEngine;
using System.Collections;

public class Stat : MonoBehaviour {

    public static int mhp;
    public static int hp;
    public static int mstamina;
    public static int stamina;
    public static int Damage;
    public static int Defend;

    void Start()
    {
        mhp = 50;
        Stat.hp = mhp;
        Stat.mstamina = 10;
        Stat.stamina = mstamina;
        Stat.Damage = 10;
        Stat.Defend = 10;
    }

}
