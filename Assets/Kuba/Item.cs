using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isTouchingPlayer = false;
    Backpack bp;

    private void Start()
    {
        bp = FindObjectOfType<Backpack>();
    }

    private void Update()
    {
        if (isTouchingPlayer && Input.GetKeyDown(KeyCode.Q))
        {
            bp.slots[bp.taken].sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
            bp.taken++;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isTouchingPlayer = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTouchingPlayer = false;
    }
}
