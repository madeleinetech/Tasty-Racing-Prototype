using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHelper : MonoBehaviour
{
  public void playGame()
    {
        SceneManager.LoadScene("candymap");
        Debug.Log("Loaded Scene");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("candymap"));
    }
}
