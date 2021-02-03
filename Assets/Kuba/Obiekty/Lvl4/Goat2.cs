using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat2 : MonoBehaviour
{
    public bool sleep = false;
    public bool touching = false;
    [SerializeField] GameObject koza;
    Backpack bp;
    RadialMenu rm;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        bp = FindObjectOfType<Backpack>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rm.activeOption == 3 ||
            rm.activeOption == 4 ||
            rm.activeOption == 5)
        {
            sleep = true;
            anim.SetBool("Sleep", true);
        }
        else
        {
            anim.SetBool("Sleep", false);
            sleep = false;
        }

        if(sleep == true)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }

        if(touching && Input.GetKeyDown(KeyCode.Q))
        {
            bp.rzeczy.Add(koza);
            Destroy(gameObject);
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
