using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroScript : MonoBehaviour
{
   public void NextScene()
    {
        SceneManager.LoadScene(0);
    }
}
