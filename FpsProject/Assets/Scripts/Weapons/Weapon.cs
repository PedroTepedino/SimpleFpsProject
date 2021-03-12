using UnityEngine;

public abstract class Weapon : MonoBehaviour, IShooter
{
    [SerializeField] private Sprite _crossHair;

    public Sprite CrossHair => _crossHair;

    public bool CanUse => Time.time >= _nextUseTime;

    protected float _nextUseTime = 0; 
    
    public abstract void Shoot();
}