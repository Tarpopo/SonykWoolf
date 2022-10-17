using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class FightCombo : MonoBehaviour
{
    [SerializeField] private float _comboTime;
    [SerializeField] private List<Combo> _combos;
    [SerializeField] private List<Attack> _baseAttacks;
    public bool IsAttack => _comboTimer.IsTick;
    private bool _isHaveCombo => _combos.Any(combo => combo.IsActive);
    private Combo _firstActiveCombo => _combos.FirstOrDefault(combo => combo.IsActive);
    private Timer _comboTimer;
    private Timer _attackTimer;
    private Timer _lockAttackTimer;
    private ActorData _actorData;
    private Attack _currentAttack;
    
    private void Start()
    {
        _comboTimer = new Timer();
        _lockAttackTimer = new Timer();
        _attackTimer = new Timer();
        _actorData = GetComponent<ActorData>();
        _actorData.UserInput.Player.SoftAttack.performed += context =>TryAttack(AttackType.Soft);
        _actorData.UserInput.Player.StrongAttack.performed += context =>TryAttack(AttackType.Strong);
    }

    private void TryAttack(AttackType attackType)
    {
        if (_lockAttackTimer.IsTick) return;
        foreach (var combo in _combos.Where(combo => combo.IsActive))
        {
            combo.IsContinueCombo(attackType);
        }
        _currentAttack = _isHaveCombo
            ? _firstActiveCombo.GetAttack(_baseAttacks[(int) attackType])
            : _baseAttacks[(int) attackType];
        if (_attackTimer.IsTick) return;
        _attackTimer.StartTimer(_currentAttack.AttackTime,TryAttack);
        TryAttack();
    }
    private void TryAttack()
    {
        if (_currentAttack == null) return;
        _lockAttackTimer.StartTimer(_currentAttack.AttackTime/2,null);
        _comboTimer.StartTimer(_currentAttack.AttackTime*1.5f, () =>
        {
            print("comboTimeLeft");
            ClearAllCombos();
        });
        _actorData.Anim.Play(_currentAttack.AttackAnimation);
        _currentAttack = null;
        print("success attack");
        if(_isHaveCombo==false) ClearAllCombos();
    }

    private void ClearAllCombos()
    {
        foreach (var combo in _combos)
        {
            combo.ResetCombo();
        }
        print("combos is clear");
    }
    private void Update()
    {
        _comboTimer.UpdateTimer();
        _lockAttackTimer.UpdateTimer();
        _attackTimer.UpdateTimer();
    }
}
[Serializable]
public class Attack
{ 
    [SerializeField] private float _divine;
    [SerializeField] private AnimationClip _attackAnimation;
    [SerializeField] private AttackType _attackType;
    public string AttackAnimation=>_attackAnimation.name;
    public int AttackType => (int) _attackType;
    public float AttackTime => _attackAnimation.length/_divine;
}

[Serializable]
public class Combo
{
    [SerializeField] private List<AttackType> _inputs;
    [SerializeField] private Attack _comboAttack;
    private int _currentInput=-1;
    public bool IsActive { get; private set;}
    public bool IsContinueCombo(AttackType input)
    {
        _currentInput++;
        if (_inputs[_currentInput] == input)
        {
            return true;
        }
        IsActive = false;
        return false;
    }
    
    public Attack GetAttack(Attack attack)
    {
        if (_currentInput != _inputs.Count - 1) return attack;
        IsActive = false;
        return _comboAttack;
    }
    public void ResetCombo()
    {
        _currentInput = -1;
        IsActive = true;
    }
}
public enum AttackType
{
    Soft,
    Strong,
}