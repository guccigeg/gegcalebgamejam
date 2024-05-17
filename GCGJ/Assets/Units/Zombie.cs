using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Zombie : MonoBehaviour
{
    public int numberOfUnit;

    public int increaseUnit;
    public double resourcesPerSecond;
    public int corpseCost;
    public int manaCost;

    
    public void increaseNumberOfUnit()
    {
        numberOfUnit += increaseUnit;
    }


}

