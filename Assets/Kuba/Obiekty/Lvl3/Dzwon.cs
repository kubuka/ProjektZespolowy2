using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dzwon : MonoBehaviour
{

    Lawina lw;
    Animator anim;
    Goat goat;
    bool dingdong = false;
    bool touching = false;
    [SerializeField] AudioClip clip;

    void Start()
    {
        lw = FindObjectOfType<Lawina>();
        goat = FindObjectOfType<Goat>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touching && dingdong == false && Input.GetKeyDown(KeyCode.Space) && lw.frozen == true)
        {
            Debug.Log("aaaaa");
            lw.PlayAnim();
            anim.SetTrigger("dingdong");
            goat.PlayAnim();
            dingdong = true;
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            touching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            touching = false;
        }
    }
}
