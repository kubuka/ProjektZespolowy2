using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
	[SerializeField] GameObject theMenu;
	public Vector2 moveInput;
	int selectedOption;
	[SerializeField] GameObject selector;

	bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
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
						selectedOption = i + 1;
						selector.transform.rotation = Quaternion.Euler(0, 0, i * -60);
					}
				}

			}

		}
    }
}
