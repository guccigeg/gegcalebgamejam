using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    int numberOfUnit = 0;

    int increaseUnit = 1;
    double resourcesPerSecond = .2;
    int corpseCost = 1;
    int manaCost = 10;

    
    int increaseNumberOfUnit()
    {
        return numberOfUnit + increaseUnit;
    }

    int returnCorpseCost(){
        return corpseCost
    }

    int returnManaCost(){
        return manaCost
    }

    double returnResoucesPerSecond(){
        return resourcesPerSecond
    }
    

}