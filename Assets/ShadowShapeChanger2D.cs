using System;
using UnityEngine;
using UnityEngine.U2D;

public class ShadowShapeChanger2D : ShadowChanger2D
{
    [SerializeField] private ShadowShapeElement _dayShadow;
    [SerializeField] private ShadowShapeElement _nightShadow;
    private ShadowShapeElement _currentShadow;
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
public class ShadowShapeElement
{
    public int TimeDuration;
    public SpriteShapeController Shadow;
    public Vector2 StartPosition;
    public Vector2 EndPosition;
    private float _step;
    private Spline _spline => Shadow.spline;
    public void ResetShadow()
    {
        _step=(EndPosition.x-StartPosition.x)/(TimeDuration/Time.fixedDeltaTime);
        SetPositions(StartPosition);
    }
    public void UpdatePosition()
    {
        var newPos = new Vector3(_spline.GetPosition(0).x,_spline.GetPosition(3).x);
        newPos.x += _step;
        newPos.y += _step;
        SetPositions(newPos);
    }

    private void SetPositions(Vector2 positions)
    {
        var newPos = new Vector3(positions.x,_spline.GetPosition(0).y,0);
        _spline.SetPosition(0,newPos);
        newPos.x = positions.y;
        _spline.SetPosition(3,newPos);
    }
}
