using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public GameObject dialogueCloud;
	public GameObject sound;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue d)
    {
		sound.GetComponent<AudioSource>().enabled = true;
		sound.GetComponent<AudioSource>().volume = 0.05f;
        nameText.text = d.name;

		sentences.Clear();

		foreach (string sentence in d.sentences)
        {
            sentences.Enqueue(sentence);
        }
		DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TyprSentence(sentence));
    }

    IEnumerator TyprSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
		StartCoroutine(WaitForNextSentence());
    }

    public void EndDialogue()
    {
		dialogueCloud.gameObject.SetActive(false);
		StartCoroutine(MuteSound());
	}

	IEnumerator WaitForNextSentence()
	{
		yield return new WaitForSeconds(3);
		DisplayNextSentence();
	}

	IEnumerator MuteSound()
	{
		while (sound.GetComponent<AudioSource>().volume > 0)
		{
			sound.GetComponent<AudioSource>().volume -= 0.01f;
			yield return new WaitForSeconds(0.2f);
			Debug.Log("aaaaa");
		}
		sound.GetComponent<AudioSource>().enabled = false;
	}
}
