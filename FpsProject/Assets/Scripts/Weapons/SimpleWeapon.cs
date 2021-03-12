using UnityEngine;

public class SimpleWeapon : Weapon
{
    [SerializeField] private float _delay = 0.1f;
    [SerializeField] private float _range = 100f;
    [SerializeField] private int _damage = 1;

    private int _layerMask;

    [SerializeField] private GameObject _hitEffect; 

    private RaycastHit[] _results = new RaycastHit[100];

    private void Awake()
    {
        _layerMask = LayerMask.GetMask("Default");
    }
    
    public override void Shoot()
    {
        _nextUseTime = Time.time + _delay;

        Ray ray = Camera.main.ViewportPointToRay(Vector3.one/ 2f);
        int hits = Physics.RaycastNonAlloc(ray, _results, _range, _layerMask, QueryTriggerInteraction.Collide);

        RaycastHit nearest = new RaycastHit();
        double nearestDistance = double.MaxValue;
        
        for (int i = 0; i < hits; i++)
        {
            var distance = Vector3.Distance(this.transform.position, _results[i].point);

            if (distance < nearestDistance)
            {
                nearest = _results[i];
                nearestDistance = distance;
            }
            
        }

        if (nearest.transform != null)
        {
            var takeHits = nearest.collider.GetComponent<IHittable>();
            takeHits?.Hit(_damage);

            Instantiate(_hitEffect, nearest.point, Quaternion.LookRotation(nearest.normal));
        }
    }
}