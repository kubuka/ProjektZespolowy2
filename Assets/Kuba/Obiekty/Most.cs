using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Most : MonoBehaviour
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
        Debug.Log(rm.activeOption);
        if (rm.activeOption == 1)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<EdgeCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<EdgeCollider2D>().enabled = false;
        }
    }
}
