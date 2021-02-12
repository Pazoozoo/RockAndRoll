using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour {
    public Rigidbody rb;

    void Update() {
        if (Input.GetMouseButtonDown(0)) 
            StartCoroutine(RecordAndPlay());
    }

    IEnumerator RecordAndPlay() {
        var targets = new Queue<Vector3>();
        
        while (Input.GetMouseButton(0)) {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hitInfo)) 
                targets.Enqueue(hitInfo.point);
            yield return null;
        }
        
        while (targets.GetEnumerator().MoveNext()) {
            var target = targets.Dequeue();
            target.y += rb.GetComponent<SphereCollider>().radius;
            rb.transform.position = target;
            yield return null;
        }
    }
}