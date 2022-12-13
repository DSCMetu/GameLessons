using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgreeBar : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform finish;

    [SerializeField] Slider slider;

    float maxDistance;

    private void Start()
    {
        maxDistance = GetDistance();
    }

    private void Update()
    {
        if(player.position.z <= maxDistance && player.position.z <= finish.position.z)
        {
            float distance = 1 - (GetDistance() / maxDistance);
            SetProgress(distance);
        }
    }

    private float GetDistance()
    {
        return Vector3.Distance(player.position, finish.position);
    }

    private void SetProgress(float progress)
    {
        slider.value = progress;
    }
}
