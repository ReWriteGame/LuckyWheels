using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private ScoreCounter scoreCounter;

    [SerializeField] private Text inputField;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;





    public void StopGame()
    { 
        int value = !string.IsNullOrEmpty(inputField.text) ?  Int32.Parse(inputField.text) : 0;
        
        if(arrow1.collidedObject.GetComponent<Cell>().Value == 1)
            scoreCounter.Add(Mathf.Abs(value));
        else scoreCounter.TakeAway(Mathf.Abs(value));
    }

    private IEnumerator StopMachineCor()
    {
        yield break;
    }
}
