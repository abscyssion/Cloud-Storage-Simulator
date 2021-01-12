using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    public static int Rand(int minR, int maxR)
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        int random = Random.Range(minR, maxR);
        return random;
    }

    public static bool Roulette(float chance)
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        float random = Random.Range(0, 1.0f);
        if (random <= chance)
            return true;
        else
            return false;
    }
}
