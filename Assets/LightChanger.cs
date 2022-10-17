using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class LightChanger : MonoBehaviour
{
    [SerializeField] private float _lowValue;
    [SerializeField] private float _highValue;
    [SerializeField] private int _frames;
    private float _currentValue;
    private Light2D _light;
    private void Start()
    {
        _currentValue = _highValue;
        _light = GetComponent<Light2D>();
        _light.intensity = _currentValue;
        StartCoroutine(ChangeLightIntensity());
    }

    private IEnumerator ChangeLightIntensity()
    {
        _currentValue = _currentValue >= _highValue ? _lowValue : _highValue;
        var step = (_currentValue - _light.intensity) / _frames;
        for (int i = 0; i < _frames; i++)
        {
            _light.intensity += step;
            yield return null;
        }
        StartCoroutine(ChangeLightIntensity());
    }
}
