using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    bool isOpened = false;
    [SerializeField] GameObject backpack;
    public List<Image> slots = new List<Image>();
    public int taken = 0;
    public GameObject combineButton;
    public Sprite finalSprite;

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

            if(taken == 5)
            {
                combineButton.SetActive(true);
            }
        }
        else
        {
            backpack.SetActive(false);
        }
    }

    public void CombineItems()
    {
        taken = 0;
        foreach (var item in slots)
        {
            item.sprite = null;
        }
        slots[taken].sprite = finalSprite;
    }
}
