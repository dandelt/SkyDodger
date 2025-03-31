using System;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    [SerializeField] protected float speed =2f;
    [SerializeField] protected Vector3 direction = Vector3.up;

    protected void Update()
    {
        this.Moving();
    }

    protected virtual void Moving()
    {
        transform.parent.Translate(this.direction * this.speed * Time.deltaTime);
    }
}
