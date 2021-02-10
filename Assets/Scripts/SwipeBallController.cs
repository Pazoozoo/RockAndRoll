using UnityEngine;

public class SwipeBallController : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody rb;
    Vector3 _screenPositionStart;
    Vector3 _endPosition;
    float _timeStart;
    float _endTime;

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            _screenPositionStart = Input.mousePosition;
            _timeStart = Time.time;
        }

        if (Input.GetMouseButtonUp(0)) {
            var screenPositionDifference = (Input.mousePosition - _screenPositionStart) / Screen.dpi;
            var timeDifference = Time.time - _timeStart;
            var worldDirection = Vector3.forward * screenPositionDifference.y + Vector3.right * screenPositionDifference.x;
            rb.AddForce(worldDirection * speed * Time.fixedDeltaTime / timeDifference, ForceMode.VelocityChange);
        }
    }
}