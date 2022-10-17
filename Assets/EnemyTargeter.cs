using UnityEngine;
public class EnemyTargeter : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _enemyLayer;
    public bool IsActive { get; private set; }
    public Vector3 EnemyPosition => _enemyTransform.position;
    private Transform _enemyTransform;
    private Collider2D[] _enemies=new Collider2D[10];
    private void Start()
    {
        _target.gameObject.SetActive(false);
    }
    
    public void TrySetTarget()
    {
        IsActive = !IsActive;
        _target.gameObject.SetActive(IsActive);
        if (IsActive == false)
        {
            _target.position = Vector2.zero;
            _enemyTransform = null;
            return;
        }
        Physics2D.OverlapCircleNonAlloc(transform.position, _radius, _enemies,_enemyLayer);
        var minDistance = _radius+1;
        foreach (var enemy in _enemies)
        {
            if(enemy==null) break;
            var distance = Vector2.Distance(enemy.transform.position, transform.position);
            if (distance < minDistance)
            {
                _enemyTransform = enemy.transform;
                minDistance = distance;
            }
        }

        if (_enemyTransform != null)
        {
            _target.position = _enemyTransform.position;
        }
        else
        {
            IsActive = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.green;
        Gizmos.DrawWireSphere(transform.position,_radius);
    }
}
