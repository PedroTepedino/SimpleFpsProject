using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Slider _sensitivitySlider;

    private void OnEnable()
    {
        Player.Instance.PlayerInputs.MenuControlls.Pause.started += PauseAction;

        if (_panel.activeInHierarchy)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Player.Instance.PlayerInputs.PlayerControlls.Disable();
            _sensitivitySlider.value = Player.Instance.Sensitivity;
        }
    }
    
    private void OnDisable()
    {
        Player.Instance.PlayerInputs.MenuControlls.Pause.started -= PauseAction;
    }
    
    private void PauseAction(InputAction.CallbackContext context)
    {
        ChangePauseState();
    }

    public void ChangePauseState()
    {
        if (!_panel.activeInHierarchy)
        {
            Time.timeScale = 0;
            _panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Player.Instance.PlayerInputs.PlayerControlls.Disable();
            _sensitivitySlider.value = Player.Instance.Sensitivity;
        }
        else
        {
            Time.timeScale = 1;
            _panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Player.Instance.PlayerInputs.PlayerControlls.Enable();
        }
    }

    public void ChangePlayerMouseSensibility()
    {
        Player.Instance.ChangeCameraMovementSpeed(_sensitivitySlider.value);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void OnValidate()
    {
        if (_sensitivitySlider == null)
        {
            _sensitivitySlider = this.GetComponentInChildren<Slider>();
        }
    }
}
