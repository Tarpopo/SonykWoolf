using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingObject : MonoBehaviour
{
    [SerializeField] private float _interval;
    [SerializeField] private float _blinkCount;

    public IEnumerator Blink(bool flag)
    {
        var active=true;
        for (int i = 0; i < _blinkCount; i++)
        {
            gameObject.SetActive(active);
            active = !active;
            yield return new WaitForSeconds(_interval);
        }
        gameObject.SetActive(flag);
    }
    
}
