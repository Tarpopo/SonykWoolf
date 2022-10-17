using System;
using UnityEngine;
public class ShadowTransformChanger2D : ShadowChanger2D
{
    [SerializeField] private ShadowTransformElement _dayShadow;
    [SerializeField] private ShadowTransformElement _nightShadow;
    private ShadowTransformElement _currentShadow;
    protected override void OnStart()
    {
        _dayShadow.ResetShadow();
        _nightShadow.ResetShadow();
        _currentShadow = _dayShadow;
        _shadowTransparency.OnDayShadowBlack+=_dayShadow.ResetShadow;
        _shadowTransparency.OnNightShadowBlack+=_nightShadow.ResetShadow;
        _dayTimer.AddAction(_dayChanger.GetDayTime(DayTime.Evening), () =>
        {
            _currentShadow = null;
        });
        _dayTimer.AddAction(_dayChanger.GetDayTime(DayTime.Night), () =>
        {
            _currentShadow = _nightShadow;
        });
        _dayTimer.AddAction(_dayChanger.GetDayTime(DayTime.Morning), () =>
        {
            _currentShadow = _dayShadow;
        });
        
    }
    protected override void ShadowChange()
    {
        _currentShadow?.UpdatePosition();
    }

}
[Serializable]
public class ShadowTransformElement
{
    public int TimeDuration;
    public Transform Shadow;
    public Vector2 StartPosition;
    public Vector2 EndPosition;
    private Vector3 _step;
    public void ResetShadow()
    {
        _step=(EndPosition-StartPosition)/(TimeDuration/Time.fixedDeltaTime);
        Shadow.localPosition = StartPosition;
    }
    public void UpdatePosition()
    {
        Shadow.localPosition += _step;
    }
}

