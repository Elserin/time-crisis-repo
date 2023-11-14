using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AreaCheck : MonoBehaviour
{
    public List<GameObject> enemies;
    public UnityEvent allEnemiesDown;
    private void Update()
    {
        if (enemies.Count == 0)
        {
            allEnemiesDown.Invoke();
        }
    }
}
