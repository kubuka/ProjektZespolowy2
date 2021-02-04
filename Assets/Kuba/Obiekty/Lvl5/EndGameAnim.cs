using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameAnim : MonoBehaviour
{
    public void AnimEndGame()
    {
        GetComponent<Animator>().SetTrigger("Now");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
