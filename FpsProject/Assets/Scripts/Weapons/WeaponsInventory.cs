using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponsInventory : MonoBehaviour
{
    [SerializeField] private Transform _handTransform;
    [SerializeField] private List<Weapon> _weapons = new List<Weapon>();
    
    private Weapon _currentWeapon = null;

    private int _currentIndex = 0;

    public static Action<Weapon> OnCurrentWeaponChanged;

    private void Awake()
    {
        foreach (var weapon in _weapons)
        {
            weapon.gameObject.SetActive(false);
            weapon.transform.localPosition = Vector3.zero;
            weapon.transform.rotation = _handTransform.rotation;
            weapon.transform.parent = _handTransform;
        }

        if (_weapons.Count > 0)
        {
            _currentWeapon = _weapons[0];
            _currentWeapon.gameObject.SetActive(true);
        }

        Player.Instance.PlayerInputs.PlayerControlls.ChangeWeapon.started += OnChangeWeapon;
        Player.Instance.PlayerInputs.PlayerControlls.Shoot.started += OnShoot;
    }

    private void OnDestroy()
    {
        Player.Instance.PlayerInputs.PlayerControlls.ChangeWeapon.started -= OnChangeWeapon;
        Player.Instance.PlayerInputs.PlayerControlls.Shoot.started -= OnShoot;
    }

    private void OnEnable()
    {
        OnCurrentWeaponChanged?.Invoke(_currentWeapon);
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        if (_currentWeapon != null && _currentWeapon.CanUse)
        {
            _currentWeapon.Shoot();
        }
    }

    private void OnChangeWeapon(InputAction.CallbackContext context)
    {
        if (_weapons.Count < 2) return;
        
        _currentIndex++;

        if (_currentIndex >= _weapons.Count)
        {
            _currentIndex = 0;
        }

        _currentWeapon.gameObject.SetActive(false);
        _currentWeapon = _weapons[_currentIndex];
        _currentWeapon.gameObject.SetActive(true);

        OnCurrentWeaponChanged?.Invoke(_currentWeapon);
    }
}