using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UiCrossHair : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    private void Awake()
    {
        WeaponsInventory.OnCurrentWeaponChanged += OnWeaponChanged;
    }

    private void OnDestroy()
    {
        WeaponsInventory.OnCurrentWeaponChanged -= OnWeaponChanged;
    }
    
    private void OnWeaponChanged(Weapon weapon)
    {
        if (weapon == null)
        {
            _image.enabled = false;
            return;
        }
        
        _image.enabled = true;
        _image.sprite = weapon.CrossHair;
    }

    private void OnValidate()
    {
        if (_image == null)
        {
            _image = this.GetComponent<Image>();
        }
    }
}
