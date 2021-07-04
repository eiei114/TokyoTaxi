using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanControl : MonoBehaviour
{
    [SerializeField] private GameObject[] cap;
    [SerializeField] private GameObject[] chain;
    [SerializeField] private GameObject[] cloth;
    [SerializeField] private GameObject[] ornaments;
    [SerializeField] private GameObject[] beard;
    [SerializeField] private GameObject[] props;
    [SerializeField] private GameObject[] hair;
    [SerializeField] private GameObject[] pants;
    [SerializeField] private GameObject[] shoes;
    [SerializeField] private GameObject[] allcloth;

    
    void Awake()
    {
        int Rand = Random.Range(0, 2);
        if (Rand == 0)
        {
            int a = Random.Range(0, cap.Length);
            int b = Random.Range(0, chain.Length);
            int c = Random.Range(0, cloth.Length);
            int d = Random.Range(0, ornaments.Length);
            int e = Random.Range(0, beard.Length);
            int f = Random.Range(0, hair.Length);
            int g = Random.Range(0, props.Length);
            int h = Random.Range(0, pants.Length);
            int i = Random.Range(0, shoes.Length);

            cap[a].SetActive(true);
            chain[b].SetActive(true);
            cloth[c].SetActive(true);
            for (int k = 0; k < ornaments.Length; k++)
            {
                ornaments[d].SetActive(true);
            }

            beard[e].SetActive(true);
            hair[f].SetActive(true);
            props[g].SetActive(true);
            pants[h].SetActive(true);
            shoes[i].SetActive(true);
        }
        else  if(Rand==1)
        {
            int i = Random.Range(0, shoes.Length);
            int f = Random.Range(0, hair.Length);
            int e = Random.Range(0, beard.Length);
            int j = Random.Range(0, allcloth.Length);
            int d = Random.Range(0, ornaments.Length);
            int g = Random.Range(0, props.Length);
            props[g].SetActive(true);
            allcloth[j].SetActive(true);
             shoes[i].SetActive(true);
             hair[f].SetActive(true);
             beard[e].SetActive(true);
             for (int k = 0; k < ornaments.Length; k++)
             {
                 ornaments[d].SetActive(true);
             }



        }

    }
}
