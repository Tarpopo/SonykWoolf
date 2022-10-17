using System;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    [SerializeField] private Vector2 _stopFieldSize;
    [SerializeField] private Transform _stopFieldCenter;
    [SerializeField] private string _playerTag;
    [SerializeField] private float _moveSpeed;
    private float _xScale;
    private Rigidbody2D _rigidbody2D;
    private Transform _playerTransform;
    private bool _isPlayer;
    private Rect _stopField;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _stopField = new Rect {center = _stopFieldCenter.position,size = _stopFieldSize};
        _xScale = transform.localScale.x;
    }

    private void Update()
    {
        if (_isPlayer == false) return;
        _stopField.center = _stopFieldCenter.position;
        if (_stopField.Contains(_playerTransform.position))
        {
            print("inRedZone");
            return;
        }
        Move();
    }

    private void Move()
    {
        var direction = _playerTransform.position-_stopFieldCenter.position;
        transform.localScale = new Vector3(Mathf.Sign(_playerTransform.position.x-transform.position.x)*_xScale, _xScale, 1);
        _rigidbody2D.MovePosition(_rigidbody2D.position+(Vector2)direction.normalized*_moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(_playerTag) == false) return;
        _isPlayer = true;
        _playerTransform = other.transform;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(_playerTag) == false) return;
        _isPlayer = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawWireCube(_stopFieldCenter.position,_stopFieldSize);
    }
}
