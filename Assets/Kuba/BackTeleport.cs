using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTeleport : MonoBehaviour
{
	Backpack bp;
    private void Awake()
    {
		bp = FindObjectOfType<Backpack>();
    }

    private void Start()
    {
        if (bp.rzeczy.Count > 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("lvl1invert");
		}
	}
}
