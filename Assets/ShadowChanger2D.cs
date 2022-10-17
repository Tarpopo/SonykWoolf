using System;
using UnityEngine;
public abstract class ShadowChanger2D : MonoBehaviour
{
    [SerializeField] protected DayTimer _dayTimer;
    [SerializeField] protected DayChanger _dayChanger;
    [SerializeField] protected ShadowTransparency _shadowTransparency;
    private void Start()
    {
        OnStart();
        _dayTimer.OnTimerUpdate += ShadowChange;
    }
    protected virtual void OnStart() { }
    protected virtual void ShadowChange() { }
}
[Serializable]
public class ShadowElement
{
    public int TimeDuration;
    public DayTime EndTime;
    public Vector2 Position;
}
