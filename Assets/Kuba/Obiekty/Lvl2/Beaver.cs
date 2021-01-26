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

    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(wyspany == false && rm.activeOption == 3 ||
            rm.activeOption == 4 ||
            rm.activeOption == 5 )
        {  
            spi = true;
        }

        if(spi && rm.activeOption == 0 ||
            rm.activeOption == 1 ||
            rm.activeOption == 2)
        {
            spi = false;
            wyspany = true;
        }

        if (!wyspany && !spi)
        {
            head.GetComponent<SpriteRenderer>().sprite = smutny;
        }

        if (wyspany)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.position = new Vector3(23, -8.7f, 0);
            head.GetComponent<SpriteRenderer>().sprite = szczesliwy;
        }
    }
}
