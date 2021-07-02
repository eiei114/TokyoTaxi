using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanControl : MonoBehaviour
{
    [SerializeField] private GameObject[] cloth;
    
    // Start is called before the first frame update
    void Awake()
    {
        int i = Random.Range(0, cloth.Length); // This creates a random number between 0 and the total number of enemies in the array (Make sure you have added enemies to the array in the inspector)
        cloth[i].SetActive(true); // Creates that random enemy
    }
}
