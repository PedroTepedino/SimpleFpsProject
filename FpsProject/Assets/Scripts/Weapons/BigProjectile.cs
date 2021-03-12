using DG.Tweening;
using UnityEngine;

public class BigProjectile : MonoBehaviour
{
    [SerializeField] private int _damage = 5;
    [SerializeField] private float _projectileSpeed = 10f;
    [SerializeField] private float _lifeTime = 5f;
    private float _timer;

    private bool _hasHitSomething = false;
    private bool _isRewinding = false;

    [SerializeField] private Rigidbody _rigidbody;

    private Tween _tween;

    private void Start()
    {
        _tween = this.transform.DOScale(0.5f, 0.2f).From(0f).SetAutoKill(false).SetEase(Ease.OutBack);
        //_tween.Pause();

        _tween.onRewind += () => Destroy(this.gameObject);

        _hasHitSomething = false;
        _isRewinding = false;
    }

    private void OnEnable()
    {
        //_tween.isBackwards = false;
        //_tween.Play();

        _rigidbody.velocity = this.transform.forward * _projectileSpeed;
    }

    private void Update()
    {
        if (!_hasHitSomething) return;

        _timer -= Time.deltaTime;

        if (_timer <= 0 && !_isRewinding)
        {
            _isRewinding = true;
            _tween.SmoothRewind();
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        var hittable = other.gameObject.GetComponent<IHittable>();
        
        hittable?.Hit(_damage);

        _hasHitSomething = true;
        _timer = _lifeTime;
    }

    private void OnValidate()
    {
        if (_rigidbody == null)
        {
            _rigidbody = this.GetComponent<Rigidbody>();
        }
    }
}