using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUi : MonoBehaviour
{
    [SerializeField] private GameObject _health;

    public void SetActiveUi(bool active)
    {
        _health.SetActive(active);
    }

}
