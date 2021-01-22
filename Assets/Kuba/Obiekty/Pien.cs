using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pien : MonoBehaviour
{
	RadialMenu rm;
	Backpack bp;
	bool zebrany = false;
	[SerializeField] Sprite miod;
	bool touching = false;

	void Start()
    {
		rm = FindObjectOfType<RadialMenu>();
		bp = FindObjectOfType<Backpack>();
    }


    void Update()
    {
        if(!zebrany &&rm.activeOption !=0 && rm.activeOption != 1)
		{
			transform.GetChild(0).gameObject.SetActive(true);
			if (touching &&Input.GetKeyDown(KeyCode.Q))
			{
				zebrany = true;
				bp.slots[bp.taken].sprite = miod;
				bp.taken++;
				transform.GetChild(0).gameObject.SetActive(false);
			}
		}
		else
		{
			transform.GetChild(0).gameObject.SetActive(false);
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
