using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaver : MonoBehaviour
{
    public bool wyspany = false;
    public bool spi = false;
    [SerializeField] GameObject head;
    [SerializeField] Sprite szczesliwy;
    [SerializeField] Sprite smutny;

    RadialMenu rm;
    Animator anim;

    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {    
        if(wyspany == false)
        {
            if(rm.activeOption == 3 ||
            rm.activeOption == 4 ||
            rm.activeOption == 5)
            {
                anim.SetTrigger("Sleep");
                spi = true;
            }
        }

        if(spi == true)
        {
            if(rm.activeOption == 0 ||
            rm.activeOption == 1 ||
            rm.activeOption == 2)
            {
                anim.SetTrigger("Happy");
                spi = false;
                wyspany = true;
                transform.localScale = new Vector3(-1, 1, 1);
                transform.position = new Vector3(22.97f, -8.92f, 0);
            }
        }

    }
}
