using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PlayerCollectUI : MonoBehaviour
{
    private TextMeshProUGUI candyText;
    // Start is called before the first frame update
    void Start()
    {
        candyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCandyText(PlayerCollect playerCollect)
    {
        candyText.text = playerCollect.NumberOfCandy.ToString();
        if (playerCollect.NumberOfCandy == 6)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

}
