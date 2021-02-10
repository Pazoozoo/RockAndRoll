using UnityEngine;
using UnityEngine.UIElements;

public class TiltController : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;

    void Update() {
        var direction = Input.acceleration * speed;
        direction = Quaternion.Euler(90, 0, 0) * direction;
        
        rb.AddForce(direction * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}