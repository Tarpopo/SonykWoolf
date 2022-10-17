using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour
{
     [SerializeField] private UnityEvent _onAxisInput; 
     [SerializeField] private UnityEvent _onAxisInputUp;
     [SerializeField] private UnityEvent _onSpaceDown;
     [SerializeField] private UnityEvent _onShiftDown;
     private bool _isAxisInput;
        public event UnityAction OnAxisInput
        {
            add => _onAxisInput.AddListener(value);
            remove => _onAxisInput.RemoveListener(value);
        }
        public event UnityAction OnAxisUp
        {
            add => _onAxisInputUp.AddListener(value);
            remove => _onAxisInputUp.RemoveListener(value);
        }
        public event UnityAction OnSpaceDown
        {
            add => _onSpaceDown.AddListener(value);
            remove => _onSpaceDown.RemoveListener(value);
        }
        
        public event UnityAction OnShiftDown
        {
            add => _onShiftDown.AddListener(value);
            remove => _onShiftDown.RemoveListener(value);
        }
        
        private void Update()
        {
            // if (Input.GetButton("Horizontal")||Input.GetButton("Vertical"))
            // {
            //     //if (Input.GetKeyDown(KeyCode.LeftShift)) return;
            //     _isAxisInput = true;
            // }
            //
            // if (Input.GetButtonUp("Horizontal")||Input.GetButtonUp("Vertical"))
            // {
            //     if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) return;
            //     _isAxisInput = false;
            //     _onAxisInputUp?.Invoke();
            // }
            //
            // if (Input.GetKeyDown(KeyCode.LeftShift))
            // {
            //     _onShiftDown?.Invoke();
            // }
            //
            // if (Input.GetKeyDown(KeyCode.Space))
            // {
            //     _onSpaceDown?.Invoke();
            // }
        }
    
        private void FixedUpdate()
        {
            if(_isAxisInput) _onAxisInput?.Invoke();
        }
}
