using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour
{
    private Canvas myCanvas;
    // Start is called before the first frame update
    void Start()
    {
        myCanvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonWasClicked()
    {
        myCanvas.enabled = false;
    }
}
