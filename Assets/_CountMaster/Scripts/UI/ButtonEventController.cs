using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventController : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private EventTriggerController eventTriggerController;


    private void Start()
    {
        button.onClick.AddListener(eventTriggerController.eventTrigger.Invoke);
    }
}
