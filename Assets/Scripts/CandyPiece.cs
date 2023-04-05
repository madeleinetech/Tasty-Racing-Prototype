using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CandyPiece : MonoBehaviour
{
    public AudioClip CollectSound;
    private void OnTriggerEnter(Collider other)
    {
    
            PlayerCollect playerCollect = other.GetComponent<PlayerCollect>();

            if (playerCollect != null)
            {
                playerCollect.CandyCollected();
                AudioSource.PlayClipAtPoint(CollectSound, transform.position);
                gameObject.SetActive(false);
            }
    }
}
