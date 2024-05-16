using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour {
    [SerializeField] private float mana = 10.0f;
    [SerializeField] private float corpses = 10.0f;
    private void Update() {

    }
    public void LoseMana(float lostMana) {
        mana -= lostMana;
    }
    public void GainMana(float gainedMana) {
        mana += gainedMana;
    }

    public void LoseCorpses(float lostCorpses) {
        corpses -= lostCorpses;
    }
    public void GainDeath(float gainedCorpses) {
        corpses += gainedCorpses;
    }
}