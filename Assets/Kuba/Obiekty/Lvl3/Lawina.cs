using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lawina : MonoBehaviour
{
    RadialMenu rm;
    Animator anim;
    public bool frozen = false;
    public bool wet = false;

    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rm.activeOption == 1)
        {
            wet = true;
            frozen = false;
        }

        if(wet == true && rm.activeOption == 5)
        {
            wet = false;
            frozen = true;
        }

        
    }

    public void PlayAnim()
    {
        anim.SetTrigger("Lawina");
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
