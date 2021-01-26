using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
	[SerializeField] GameObject theMenu;
	public Vector2 moveInput;
	 int selectedOption;
	[SerializeField] GameObject selector;

	bool isActive = false;

	public List<GameObject> options = new List<GameObject>();
	public int activeOption = 1;

	Animator anim;

	public bool sleeping = false;

	// Start is called before the first frame update
	void Start()
    {
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Tab))
		{
			isActive = !isActive;
			theMenu.SetActive(isActive);
		}

		if (theMenu.activeInHierarchy)
		{
			moveInput.x = Input.mousePosition.x - (Screen.width / 2f);
			moveInput.y = Input.mousePosition.y - (Screen.height / 2f);
			moveInput.Normalize();

			if(moveInput != Vector2.zero)
			{
				float angle = Mathf.Atan2(moveInput.y, -moveInput.x) / Mathf.PI;
				angle *= 180;
				if(angle < 0)
				{
					angle += 360;
				}

				for (int i = 0; i < 6; i++)
				{
					if(angle > i * 60 && angle < (i +1) * 60)
					{
						selectedOption = i;
						selector.transform.rotation = Quaternion.Euler(0, 0, i * -60);
					}
				}

			}

			if (Input.GetKeyDown(KeyCode.Mouse0))
			{
				isActive = !isActive;
				anim.SetTrigger("Sleep");
				theMenu.SetActive(isActive);
			}
		}
    }

	public void ChangeBackGround()
    {
		for (int i = 0; i < options.Count; i++)
		{
			if (i == selectedOption)
			{
				activeOption = i;
				options[i].SetActive(true);
				Debug.Log(activeOption);
			}
			else
			{
				options[i].SetActive(false);
			}
		}
	}

	public void IsSleeping()
    {
		sleeping = !sleeping;
    }
}
