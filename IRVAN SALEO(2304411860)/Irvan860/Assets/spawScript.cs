using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawScript : MonoBehaviour
{
    float time = 0;
    public float timer = 1;
    public GameObject pipa;

    void Update()
    {
        if (time <= 0)
        {
            Instantiate(pipa, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime; 
        }
    }
}
