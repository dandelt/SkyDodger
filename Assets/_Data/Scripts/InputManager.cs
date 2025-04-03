using System;
using UnityEngine;

public class InputManager : DanMonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance => instance;
    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos => mouseWorldPos;
    [SerializeField] protected float onFiring;
    public float OnFiring => onFiring;

    protected override void Awake()
    {
        InputManager.instance = this;
    }

    private void Update()
    {
        GetMouseDown();
    }

    void FixedUpdate()
    {
        this.GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
