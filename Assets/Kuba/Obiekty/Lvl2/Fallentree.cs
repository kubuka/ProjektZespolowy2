using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallentree : MonoBehaviour
{
    bool fallen = false;
    Beaver bv;
    Animator anim;

    [SerializeField] GameObject colliders;
    [SerializeField] AudioClip clip;
    bool playClip;

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
            playClip = true;
            colliders.SetActive(false);
            anim.SetTrigger("Fall");
            GetComponent<PolygonCollider2D>().enabled = true;
        }
    }

    public void PlayClip()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
