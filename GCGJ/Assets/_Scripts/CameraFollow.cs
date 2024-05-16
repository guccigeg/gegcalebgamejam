using UnityEngine;
public class CameraFollow : MonoBehaviour {
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Vector3 offset;

    private Camera mainCamera;
    public float edgeThreshold = 0.1f;
    public float centeringSpeed = 2.0f;
    public float idleThreshold = 0.1f;
    private float sensitivity = 10.0f;

    private Vector3 targetViewportPosition;

    void Start() {
        mainCamera = GetComponent<Camera>();
    }

    void FixedUpdate() {
        if (target == null)
            return;

        targetViewportPosition = mainCamera.WorldToViewportPoint(target.position);

        if (targetViewportPosition.x < edgeThreshold || targetViewportPosition.x > 1 - edgeThreshold ||
            targetViewportPosition.y < edgeThreshold || targetViewportPosition.y > 1 - edgeThreshold ||
            Mathf.Abs(target.GetComponent<Rigidbody>().velocity.magnitude) < idleThreshold) {

            // Calculate the target position with z-axis offset
            Vector3 targetPosition = target.position + offset;

            // Smoothly move the camera towards the target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, centeringSpeed);
        }
    }
    private void Update() {
        //League style camera - move screen left or right if curser touches edge
        if (Input.mousePosition.x < sensitivity)
            transform.Rotate(-Vector3.up * Time.deltaTime * Mathf.Abs(sensitivity - Input.mousePosition.x));
        else if (Input.mousePosition.x > Screen.width - sensitivity)
            transform.Rotate(Vector3.up * Time.deltaTime * Mathf.Abs(Screen.width - Input.mousePosition.x));
    }



}