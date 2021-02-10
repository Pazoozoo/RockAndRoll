using UnityEngine;

public class ResetPosition : MonoBehaviour {
    Vector3 _startPosition;
    Rigidbody _rb;
    const float ResetHeight = -3f;

    void Start() {
        _startPosition = transform.position;
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        if (transform.position.y > ResetHeight) return;
        
        _rb.velocity = Vector3.zero;
        transform.position = _startPosition;
    }
}
