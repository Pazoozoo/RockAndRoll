using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{
    // public float speed = 1f;
    public Rigidbody rb;
    Queue<Vector3> _targets = new Queue<Vector3>();

    void Update() {
        if (Input.GetMouseButton(0)) {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out var hitInfo);
            
            _targets.Enqueue(hitInfo.point);
            return;
        }   
        
        if (_targets.Count == 0) return;
        MoveBall(_targets.Dequeue());
    }

    void MoveBall(Vector3 target) {
        var offset = new Vector3(0f, 0.5f, 0f);
        rb.transform.position = target + offset;
    }
}