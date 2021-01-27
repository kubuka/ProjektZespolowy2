using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
	public GameObject dialogueCloud;
	public TextMeshProUGUI dialoguePlace;
	public TextMeshProUGUI namePlace;
	public GameObject sound;

	bool touchingPlayer = false;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && touchingPlayer)
		{
			TriggerDialogue();
		}
	}

	//tutaj trzeba zrobic warunek kiedy sie odpala dialog
	public void TriggerDialogue()
    {
		FindObjectOfType<DialogueManager>().dialogueText = dialoguePlace;
		FindObjectOfType<DialogueManager>().nameText = namePlace;
		FindObjectOfType<DialogueManager>().sound = sound;
		FindObjectOfType<DialogueManager>().dialogueCloud = dialogueCloud;
		dialogueCloud.gameObject.SetActive(true);
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			touchingPlayer = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			touchingPlayer = false;
		}
	}
}
