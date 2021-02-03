using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : MonoBehaviour
{
    Animator anim;
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

   public void PlayAnim()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        anim.SetTrigger("Run");
    }
}
