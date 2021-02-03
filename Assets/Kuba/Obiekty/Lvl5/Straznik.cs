using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straznik : MonoBehaviour
{
    RadialMenu rm;
    AudioSource audio;
    [SerializeField] AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rm.activeOption == 3 ||
            rm.activeOption == 4 ||
            rm.activeOption == 5)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            audio.enabled = true;
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            audio.enabled = false;
        }
    }
}
