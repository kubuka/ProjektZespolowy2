using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Znak : MonoBehaviour
{
    [SerializeField] GameObject doPokazania;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            doPokazania.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            doPokazania.SetActive(false);
        }
    }
}
