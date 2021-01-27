using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    RadialMenu rm;
    Animator anim;
    public bool noc;

    [SerializeField] GameObject colliders;

    private void Start()
    {
        rm = FindObjectOfType<RadialMenu>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rm.activeOption == 3 ||
            rm.activeOption == 4 ||
            rm.activeOption == 5)
        {
            anim.SetBool("Night", true);
            colliders.SetActive(false);
        }
        else
        {
            colliders.SetActive(true);
            anim.SetBool("Night", false);
            GetComponent<EdgeCollider2D>().enabled = false;
        }
    }

    public void TriggerCollider()
    {
        GetComponent<EdgeCollider2D>().enabled = true;
    }
}
