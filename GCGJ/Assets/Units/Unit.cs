using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    int numberOfUnit = 0;
    int resourcesPerSecond = 0;
    int costCorpse = 0;
    int costMana = 0;
}
public class Zombie : Unit
{
    string resourceType = 'Corpses';
    costCorpse = 1;
    costMana = 10;
    resourcesPerSecond = .2;
}
