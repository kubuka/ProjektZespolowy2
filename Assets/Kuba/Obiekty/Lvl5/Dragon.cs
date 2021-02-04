using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] SpriteRenderer placeToSpawn;
    Backpack bp;
    bool touching = false;
    [SerializeField] EndGameAnim anim;
    [SerializeField] Sprite koza;
    RadialMenu rm;
    
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        bp = FindObjectOfType<Backpack>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && touching && bp.rzeczy.Count == 1)
        {
            rm.sleeping = true;
            placeToSpawn.sprite = koza;
            anim.AnimEndGame();
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
