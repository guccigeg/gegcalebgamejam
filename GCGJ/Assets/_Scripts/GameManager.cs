using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
public class GameManager : MonoBehaviour {

    public int corpses;
    public TextMeshProUGUI corpseText;
    public static GameManager instance;
    void Awake(){
        instance = this;
    }

    public void AddCorpse(int amount){
        corpses += amount;
        corpseText.text = "SkullEmoji: " + corpses.ToString();
    }
    
    public void UseCorpse(int amount){
        corpses -= amount;
    }
}