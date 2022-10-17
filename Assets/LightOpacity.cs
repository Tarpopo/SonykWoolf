using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightOpacity : MonoBehaviour
{
    [SerializeField] private DayTimer _dayTimer;
    [SerializeField] private Color _toColor;
    [SerializeField] private int _frames;
    private Light2D _light2D;
    private void Start()
    {
        _light2D=GetComponent<Light2D>();
        _dayTimer.AddAction(45, ()=>StartCoroutine(ChangeColor(_light2D, _toColor, _frames)));
        _dayTimer.AddAction(80, ()=>StartCoroutine(ChangeColor(_light2D, Color.black, _frames)));
    }
    private IEnumerator ChangeColor(Light2D light,Color target ,int frames)
    {
        var deltaColor = (target - light.color) / frames;
        for (int i = 0; i < frames; i++)
        {
            light.color += deltaColor;
            yield return null;
        }
    }
}
