using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float smoothSpeed = 5f;
    [SerializeField] float deadZoneY = 2f;
    [SerializeField] float lookAheadX = 2f;

    float currentLookAhead;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 pos = transform.position;

        // Horizontal look ahead
        float direction = Mathf.Sign(target.GetComponent<Rigidbody2D>().linearVelocity.x);
        currentLookAhead = Mathf.Lerp(currentLookAhead, direction * lookAheadX, Time.deltaTime * 3f);

        float targetX = target.position.x + currentLookAhead;

        // Vertical dead zone
        float targetY = pos.y;

        if (target.position.y > pos.y + deadZoneY)
            targetY = target.position.y - deadZoneY;

        if (target.position.y < pos.y - deadZoneY)
            targetY = target.position.y + deadZoneY;

        Vector3 targetPos = new Vector3(targetX, targetY, pos.z);

        transform.position = Vector3.Lerp(pos, targetPos, smoothSpeed * Time.deltaTime);
    }
}