using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    bool isOpened = false;
    [SerializeField] GameObject backpack;
    public List<GameObject> rzeczy = new List<GameObject>();
    public List<Image> slots = new List<Image>();
    public int taken = 0;
    public GameObject combineButton;
    public GameObject finalSprite;

    RadialMenu rm;


    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rm.sleeping)
        {
            isOpened = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && !rm.sleeping)
        {
            isOpened = !isOpened;
        }

        if (isOpened)
        {
            backpack.SetActive(true);
            for (int i = 0; i < rzeczy.Count; i++)
            {
                slots[i].sprite = rzeczy[i].GetComponent<SpriteRenderer>().sprite;
                taken++;
            }

            if(taken == 0)
            {
                foreach (var item in slots)
                {
                    item.sprite = null;
                }
            }

            if(rzeczy.Count == 5)
            {
                combineButton.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < rzeczy.Count; i++)
            {
                slots[i].sprite = null;
            }
            taken = 0;
            backpack.SetActive(false);
        }
    }

    public void CombineItems()
    {
        rzeczy.Clear();
        foreach (var item in slots)
        {
            item.sprite = null;
        }
        rzeczy.Add(finalSprite);
    }
}
