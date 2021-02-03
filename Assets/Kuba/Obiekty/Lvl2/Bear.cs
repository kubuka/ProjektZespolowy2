using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bear : MonoBehaviour
{
    public bool inRange = false;
    Backpack bp;
    Animator anim;
    [SerializeField] GameObject item;
    void Start()
    {
        bp = FindObjectOfType<Backpack>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.Space))
        {
            if (bp.rzeczy.Count == 1)
            {           
                anim.SetTrigger("Dobry");
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);              
                bp.rzeczy.RemoveAt(0);
                bp.taken = 0;
                bp.rzeczy.Add(item);
            }
            else
            {
                anim.SetTrigger("Zly");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inRange = false;
        }
    }

}
