using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorData : MonoBehaviour
{
    [SerializeField] private List<float> _attackDistance;
    [SerializeField] private AnimationClip _walkFight;
    private FightCombo _fightCombo;
    private PlayerUi _playerUi;
    private EnemyTargeter _enemyTargeter;
    public bool IsTargeter => _enemyTargeter.IsActive;
    public Vector3 TargetDirection => (_enemyTargeter.EnemyPosition-transform.position).normalized;
    public bool IsAttack => _fightCombo.IsAttack;
    public string WalkFight => _walkFight.name;
    
    [SerializeField] private AnimationClip _idleFight;
    public string IdleFight => _idleFight.name;
    
    public MoveElement[] MoveElements;
    public PlayerInput UserInput{ get; private set; }
    public Rigidbody2D RigidBody { get; private set; }
    public Animator Anim { get; private set; }
    //public int LookFace => (int) Mathf.Sign(transform.localScale.x);
    public bool IsFight { get; private set; }
    public float RollTime => _rollTime;
    [SerializeField] private float _rollTime;
    
    public float RollForce => _rollForce;
    [SerializeField] private float _rollForce;
    
    // public float MoveSpeed => _moveSpeed;
    // [SerializeField] private float _moveSpeed = 15;

    private void Awake()
    {
        UserInput = new PlayerInput();
        _playerUi = GetComponent<PlayerUi>();
        _fightCombo = GetComponent<FightCombo>();
        RigidBody = GetComponent<Rigidbody2D>();
        _enemyTargeter = GetComponent<EnemyTargeter>();
        Anim = GetComponent<Animator>();
        UserInput.Player.FightState.performed += context =>
        {
            IsFight = !IsFight;
            _playerUi.SetActiveUi(IsFight);
            Anim.Play(IsFight?IdleFight:"Idle");
        };
        UserInput.Player.SoftAttack.performed += context =>
        {
            IsFight = true;
            _playerUi.SetActiveUi(IsFight);
        };
        UserInput.Player.StrongAttack.performed += context =>
        {
            IsFight = true;
            _playerUi.SetActiveUi(IsFight);
        };
        UserInput.Player.Targeter.performed += context =>
        {
            _enemyTargeter.TrySetTarget();
            SetLookDirection();
        };
    }
    private void OnEnable()
    {
        UserInput.Enable();
    }

    private void OnDisable()
    {
        UserInput.Disable();
    }

    public void OnceMove(AttackType attackType)
    {
        var direction = _enemyTargeter.IsActive? (Vector2)TargetDirection:Vector2.right * transform.localScale.x;
        RigidBody.MovePosition(RigidBody.position+direction*_attackDistance[(int)attackType]);
    }
    public void SetLookDirection()
    {
        transform.localScale = new Vector3(
            Mathf.Sign(IsTargeter?TargetDirection.x:UserInput.Player.Move.ReadValue<Vector2>().normalized.x),
            1,
            1);
    }
}
[Serializable]
public class MoveElement
{
    [SerializeField] private float _moveSpeed;
    public float MoveSpeed => _moveSpeed;
    public AnimationClip Move;
}
