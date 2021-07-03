using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanControl : MonoBehaviour
{
    [SerializeField] private GameObject[] cloth;
    [SerializeField] private GameObject[] beard;
    [SerializeField] private GameObject[] props;
    [SerializeField] private GameObject[] hair;
    
    // Start is called before the first frame update
    void Awake()
    {
        int a = Random.Range(0, cloth.Length);
        int c = Random.Range(0, beard.Length);
        int e = Random.Range(0, hair.Length);
        int g = Random.Range(0, props.Length);

        
        for (int i = 0; i < a; i++)
        {
            int b = Random.Range(0, cloth.Length); // This creates a random number between 0 and the total number of enemies in the array (Make sure you have added enemies to the array in the inspector)
            cloth[b].SetActive(true);
        }
        beard[c].SetActive(true);
        hair[e].SetActive(true);
        props[g].SetActive(true);
        
    }
}
