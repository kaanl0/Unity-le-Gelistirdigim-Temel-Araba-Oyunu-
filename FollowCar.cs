using UnityEngine;

public class FollowCar : MonoBehaviour
{
    [SerializeField] private Transform target; // Araba
    [SerializeField] private Vector3 offset = new Vector3(0f, 5f, -10f);
    [SerializeField] private float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        // Kamerayý her karede arabanýn arkasýna göre konumlandýr
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Arabaya bakmayý sürdür
    }
}
