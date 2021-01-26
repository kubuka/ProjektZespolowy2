using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bees : MonoBehaviour
{
    RadialMenu rm;

    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(rm.activeOption != 0 && rm.activeOption != 1)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
            for (int i = 0; i < 11; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
            for (int i = 0; i < 11; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
