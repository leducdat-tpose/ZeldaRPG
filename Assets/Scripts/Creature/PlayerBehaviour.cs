using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : HighHuman
{
    private Rigidbody2D _rb;
    protected Vector2 _moveDirection;
    //*****ISingleton
    public static PlayerBehaviour Instance { get; private set; }
    public static bool IsInstantiated => Instance != null;
    protected virtual void Awake()
    {
        if (IsInstantiated && Instance != (PlayerBehaviour)this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = (PlayerBehaviour)this;
    }
    protected virtual void OnDestroy()
    {
        if (Instance == (PlayerBehaviour)this)
        {
            Instance = null;
        }
    }
    //*********
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        AdjustSpeed(5.0f);
        RollAbility(true);

    }
    private void Update()
    {
        UpdateInput();
    }
    private void FixedUpdate()
    {
        Moving();
    }
    private void UpdateInput()
    {
        _moveDirection.y = Input.GetAxis("Vertical");
        _moveDirection.x = Input.GetAxis("Horizontal");
    }
    protected override void Moving()
    {
        if (_rb != null)
        {
            //_rb.MovePosition(_rb.position + this._speed * _moveDirection * Time.fixedDeltaTime);
            _rb.velocity = _moveDirection * this._speed;
        }
    }
}
