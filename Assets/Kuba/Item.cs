using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isTouchingPlayer = false;
    public GameObject prefab;
    Backpack bp;

    private void Start()
    {
        bp = FindObjectOfType<Backpack>();
    }

    private void Update()
    {
        if (isTouchingPlayer && Input.GetKeyDown(KeyCode.Q))
        {
            bp.rzeczy.Add(prefab);
            Destroy(gameObject);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isTouchingPlayer = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isTouchingPlayer = false;
        }
    }
}
