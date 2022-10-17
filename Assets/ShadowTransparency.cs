using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ShadowTransparency : MonoBehaviour
{
    [SerializeField] private DayChanger _dayChanger;
    [SerializeField] private DayTimer _dayTimer;
    [SerializeField] private Material _dayShadow;
    [SerializeField] private Material _nightShadow;
    [SerializeField] private int _changeSpeed;
    private static readonly int _color = Shader.PropertyToID("_Color");
    public UnityAction OnDayShadowBlack;
    public UnityAction OnNightShadowBlack;
    private void Start()
    {
        var dayTime = _dayChanger.GetDayTime(DayTime.Night);
        _dayTimer.AddAction(dayTime, () =>
        {
            StartCoroutine(ChangeTransparency(_dayShadow,Color.black, _changeSpeed,OnDayShadowBlack));
        });
        _dayTimer.AddAction(_dayChanger.GetDayTime(DayTime.Morning), () =>
        {
            StartCoroutine(ChangeTransparency(_dayShadow,Color.white, _changeSpeed));
        });
        _dayTimer.AddAction(dayTime, () =>
        {
            StartCoroutine(ChangeTransparency(_nightShadow,Color.white, _changeSpeed));
        });
        _dayTimer.AddAction(_dayChanger.GetDayTime(DayTime.Morning), () =>
        {
            StartCoroutine(ChangeTransparency(_nightShadow,Color.black, _changeSpeed,OnNightShadowBlack));
        });
    }
    private IEnumerator ChangeTransparency(Material material,Color target ,int frames,UnityAction action=null)
    {
        var deltaColor = (target - material.GetColor(_color)) / frames;
        for (int i = 0; i < frames; i++)
        {
            material.SetColor(_color,material.GetColor(_color)+deltaColor);
            yield return null;
        }
        action?.Invoke();
    }
}
