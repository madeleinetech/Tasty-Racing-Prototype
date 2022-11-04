using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick2 : MonoBehaviour
{
    private Canvas myCanvas;
    private bool m_SceneLoaded;
    private AsyncOperation _SceneAsync;

    void Start()
    {
        myCanvas = GetComponent<Canvas>();
    }
    public void ButtonWasClicked()
    {
        
    }

    void SetActiveScene()
    {
        SceneManager.LoadScene("candymap", LoadSceneMode.Additive);
        //StartCoroutine(LoadScene("candymap"));
        // Set Scene2 as the active Scene
        
        // Ouput the name of the active Scene
        // See now that the name is updated
        Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
    
    }

    //IEnumerator loadScene(string sceneName)
    //{
    //    int i=0;
    //    while (i==3){
    //        i++;
     //       Debug.Log("Loading");
    //        yield return null;
    //    }
     //   SceneManager.SetActiveScene(SceneManager.GetSceneByName("candymap"));
     //   yield break;

    //}
}