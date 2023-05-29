using UnityEngine;


public class CameraControl : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float sensitivity = .5f;
    public float teleportOffset = 1f;


    private Vector2 mouseInput;

    [SerializeField] Transform rayOrigin;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Camera Movement
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);


        // Camera Rotation
        if (Input.GetMouseButton(1))
        {
            mouseInput.x += Input.GetAxis("Mouse X") * sensitivity;
            mouseInput.y += Input.GetAxis("Mouse Y") * sensitivity;
            transform.localRotation = Quaternion.Euler(-mouseInput.y, mouseInput.x, 0f);
        }

        
        // Teleportation
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 teleportPosition = hit.point + new Vector3(0f, teleportOffset, 0f);
                transform.position = teleportPosition;
            }
        }
    }
}
