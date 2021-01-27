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
                anim.SetBool("Sleep", true);
                spi = true;
            }
        }

        if(spi == true)
        {
            if(rm.activeOption == 0 ||
            rm.activeOption == 1 ||
            rm.activeOption == 2)
            {
                Debug.Log("aaaaaaaaaa");
                anim.SetBool("Sleep", false);
                spi = false;
                wyspany = true;
            }
        }

        if (wyspany == false && !spi)
        {
            head.GetComponent<SpriteRenderer>().sprite = smutny;
        }

        if (wyspany)
        {
            head.GetComponent<SpriteRenderer>().sprite = szczesliwy;
        }
    }
}
