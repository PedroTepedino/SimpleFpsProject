using UnityEngine;

public class BallWeapon : Weapon
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _projectileExitPoint;
    
    public override void Shoot()
    {
        var pjctl = Instantiate(_projectile, _projectileExitPoint.position, _projectileExitPoint.rotation);
        pjctl.SetActive(true);
    }
}