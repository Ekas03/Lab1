using System.Collections;
using System.Collections.Generic;
using _Source.Core;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ResourceBank _resourceBank;
    
    void Awake()
    {
        _resourceBank.ChangeResource(GameResource.Humans, 10);
        _resourceBank.ChangeResource(GameResource.Food, 5);
        _resourceBank.ChangeResource(GameResource.Wood, 5);
    }
}
