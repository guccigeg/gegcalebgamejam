using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    [SerializeField] private float health 10.0f;
    [SerializeField] float death 10.0f;
    [SerializeField] float life 10.0f;
    [SerializeField] float gold 10.0f;


    Debug.log(health, death, life, gold);
}
