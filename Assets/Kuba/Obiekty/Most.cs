﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Most : MonoBehaviour
{
    RadialMenu rm;
	Animator anim;

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
			anim.SetBool("IsMid", true);
           // GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<EdgeCollider2D>().enabled = true;
        }
        else
        {
			anim.SetBool("IsMid", false);
			// GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<EdgeCollider2D>().enabled = false;
        }
    }

	public void DestroyMask()
	{
		Destroy(transform.GetChild(0));
	}
}
