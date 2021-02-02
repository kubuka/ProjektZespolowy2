using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woda : MonoBehaviour
{
    RadialMenu rm;
    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rm.activeOption == 5)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
