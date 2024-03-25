using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameResource resourseType;
    public GameResource prodLvl;
    public ResourceBank resourceBank;
    public int cost;

    public void LvlUp()
    {
        int bankAmount = resourceBank.GetResource(resourseType).Value;
        if (bankAmount < cost)
        {
            Debug.Log("Not enough to lvl up!");
            return;
        }
        resourceBank.ChangeResource(resourseType, (-1) * cost);
        resourceBank.ChangeResource(prodLvl, 1);
        Debug.Log("ProdLvl raised to " + resourceBank.GetResource(prodLvl).Value);
    }
}
