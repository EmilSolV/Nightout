using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this to control the camera movement speed.
    public float sensitivity = 2.0f; // Adjust this to control mouse sensitivity.

    private void Update()
    {
        // Camera Rotation with Mouse Input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);

        // Camera Movement with Keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}




