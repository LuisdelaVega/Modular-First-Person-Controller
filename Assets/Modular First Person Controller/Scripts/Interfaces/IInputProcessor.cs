using UnityEngine.InputSystem;

public interface IInputProcessor
{
  void InputActionHandler(InputAction.CallbackContext value);
}
