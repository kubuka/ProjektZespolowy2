using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] float speed = 1;
	bool isGrounded = true;
	float horizontal;
	float vertical;
	Rigidbody2D rb;

	Vector2 jump;
	[SerializeField] float jumpForce = 1;

	RadialMenu rm;
	
    // Start is called before the first frame update
    void Start()
    {
		rm = FindObjectOfType<RadialMenu>();
		rb = GetComponent<Rigidbody2D>();
		jump = new Vector2(0, 2f);
    }

    // Update is called once per frame
    void Update()
    {
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");

		if(rm.sleeping == false)
        {
			if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
			{
				transform.Translate(new Vector2(horizontal * speed * Time.fixedDeltaTime, 0));
			}
		}
		

	}

	
}
