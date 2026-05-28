using System.Security;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float smoothSpeed = 5f;
    [SerializeField] float deadZoneY = 2f;
    [SerializeField] float lookAheadX = 2f;

    public bool started;
    float currentLookAhead;

    public GameObject load;

    public GameObject load2;


    float time;

    void Start()
    {
        time = 0.3f;
        //load2.SetActive(false);
    }

    void LateUpdate()
    {
        if (target == null) return;
        if(started)
        {
            //load2.SetActive(true);
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
            if(time <= 0f)
            {
                //load.SetActive(false);
            }
        }
    }
    public void GetBoolTrue()
    {
        started = true;
    }
    void FixedUpdate()
    {
        if(started)time -= Time.fixedDeltaTime;
    }

}