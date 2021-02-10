using UnityEngine;
using UnityEngine.UIElements;

public class PointerController : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;

    void Update() {
        if (Input.GetMouseButton(0)) {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out var hitInfo);

            var direction = hitInfo.point - transform.position;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}