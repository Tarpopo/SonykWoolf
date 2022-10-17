using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class DayChanger : MonoBehaviour
{
    [SerializeField] private Color _clear;
    [SerializeField] private Color _white;
    [SerializeField] private Light2D _globalLight;
    [SerializeField] private int _changeSpeed;
    [SerializeField] private DayTimer _dayTimer;
    [SerializeField] private Color _morning;
    [SerializeField] private Color _evening;
    [SerializeField] private Color _night;
    [SerializeField] private BlinkingObject _blinkingObject;
    [SerializeField] private List<TimeOfDay> _timeOfDay;
    public int ChangeSpeed=>_changeSpeed;
    public int GetDayTime(DayTime time) => _timeOfDay[(int) time].Time;
    private void Start()
    {
        _dayTimer.AddAction(_timeOfDay[0].Time, () =>
        {
            StartCoroutine(ImageToColorAnim(_globalLight,_morning, _changeSpeed));
            StartCoroutine(_blinkingObject.Blink(false));
        });
        
        _dayTimer.AddAction(_timeOfDay[1].Time, () =>
        {
            StartCoroutine(ImageToColorAnim(_globalLight,_white,_changeSpeed));
        });
        
        _dayTimer.AddAction(_timeOfDay[2].Time, () =>
        {
            StartCoroutine(ImageToColorAnim(_globalLight,_evening, _changeSpeed));
        });
        
        _dayTimer.AddAction(_timeOfDay[3].Time, () =>
        {
            StartCoroutine(ImageToColorAnim(_globalLight,_night, _changeSpeed));
            StartCoroutine(_blinkingObject.Blink(true));
        });
    }

    public static IEnumerator ImageToColorAnim(Light2D image, Color target, int frames)
    {
        Color deltaColor = (target - image.color) / frames;

        Color tempColor = image.color;

        for (int i = 0; i < frames; i++)
        {
            tempColor += deltaColor;
            image.color = tempColor;

            yield return null;
        }
        print("chenged");
    }
}
[Serializable]
public class TimeOfDay
{
    public int Time;
    public DayTime DayTime;
    public Color TimeColor;
}
public enum DayTime
{
    Morning,
    Day,
    Evening,
    Night
}