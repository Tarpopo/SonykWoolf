using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DayTimer : MonoBehaviour
{
    private Dictionary<int, Action> _dayActions=new Dictionary<int, Action>();
    [SerializeField] private int _dayTimeInSeconds=100;
    private float _currentTime;
    private int _time=0;
    public int DayTime => _time;
    [SerializeField] private UnityEvent _onTimerUpdate;
    public event UnityAction OnTimerUpdate
    {
        add => _onTimerUpdate.AddListener(value);
        remove => _onTimerUpdate.RemoveListener(value);
    }

    public void AddAction(int time, Action action)
    {
        if (_dayActions.ContainsKey(time))
        {
            _dayActions[time] += action;
            return;
        }
        _dayActions.Add(time,action);
    }

    private void FixedUpdate()
    {
        _onTimerUpdate?.Invoke();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (Mathf.Ceil(_currentTime)<_time) return;
        _time++;
        if (_dayActions.ContainsKey(_time))
        {
            _dayActions[_time].Invoke();
        }

        if (_time > _dayTimeInSeconds)
        {
            _time = 0;
            _currentTime = 0;
        }
    }
}
