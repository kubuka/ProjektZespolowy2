using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    bool isOpened = false;
    [SerializeField] GameObject backpack;
    public List<Image> slots = new List<Image>();
    int taken = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isOpened = !isOpened;
        }

        if (isOpened)
        {
            backpack.SetActive(true);
        }
        else
        {
            backpack.SetActive(false);
        }
    }
}
