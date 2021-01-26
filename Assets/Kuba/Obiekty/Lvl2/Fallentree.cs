using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallentree : MonoBehaviour
{
    bool fallen = false;
    Beaver bv;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        bv = FindObjectOfType<Beaver>();
    }


    // Update is called once per frame
    void Update()
    {
        if (bv.wyspany)
        {
            fallen = true;
        }

        if (fallen)
        {
            anim.SetTrigger("Fall");
            GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
