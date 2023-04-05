using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollect : MonoBehaviour
{
     //all scripts can get only this one can set
     public int NumberOfCandy { get; private set; }

     public UnityEvent<PlayerCollect> OnCandyCollected;

     public void CandyCollected()
     {
          NumberOfCandy++;
          OnCandyCollected.Invoke(this);
     }
}
