using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalResources : MonoBehaviour
{
    public static int CorpseCount;
    public GameObject CorpseDisplay;
    public int InternalCorpse;
    void Update (){
        InternalCorpse = CorpseCount;
        CorpseDisplay.GetComponent<Text>().text = "Corpses: " + InternalCorpse;
    }
}
