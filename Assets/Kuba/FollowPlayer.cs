using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float offset = 2f;
    [SerializeField] GameObject player;


    void Update()
    {
        if (player != null)
        {
            gameObject.transform.position =
            new Vector3(player.transform.position.x, player.transform.position.y + offset,-10);
        }
      
    }
}
