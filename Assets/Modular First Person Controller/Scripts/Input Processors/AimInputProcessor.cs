using UnityEngine;
using UnityEngine.InputSystem;

public class AimInputProcessor : MonoBehaviour
{
  private Transform m_transform;

  [Header("Settings")]
  [SerializeField, Range(0f, 1f)] private float sensitivity = 0.15f;
  [SerializeField] private bool invertY = false;
  [SerializeField, Range(0f, 90f), Tooltip("Max amount of degrees a player can turn on the X-Axis (to look up or down)")] private float xRotationClamp = 80;

  private float xRotation = 0f; // Rotation on the X-Axis (to look Up & Down)
  private float yRotation = 0f; // Rotation on the Y-Axis (to look Left & Right)
  private Vector2 playerInput = Vector2.zero;

  private void Awake() => m_transform = transform;

  private void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    yRotation = m_transform.localRotation.eulerAngles.y;
  }

  private void Update() => PerformAction();

  // Called by the Player Input component
  public void InputActionHandler(InputAction.CallbackContext value) => playerInput = value.ReadValue<Vector2>();

  private void PerformAction()
  {
    yRotation += playerInput.x * sensitivity; // Left & Right
    xRotation -= playerInput.y * sensitivity * (invertY ? -1 : 1); // Up & Down
    xRotation = Mathf.Clamp(xRotation, -xRotationClamp, xRotationClamp);

    m_transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
  }
}
