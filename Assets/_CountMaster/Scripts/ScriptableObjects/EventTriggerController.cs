using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventTriggerController", menuName = "EventTrigger/EventTriggerController")]
public class EventTriggerController : ScriptableObject
{
   public Action eventTrigger;
}
