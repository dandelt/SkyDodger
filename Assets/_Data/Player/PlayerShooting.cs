using System;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootDelay = 0.1f;
    [SerializeField] protected float shootTimer = 0f;


    private void Update()
    {
        this.IsShooting();
    }

    void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if(!this.isShooting) return;
        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0f;
        Vector3 spawnPos = transform.parent.position;
        Quaternion spawnRot = transform.parent.rotation;
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bulletOne,spawnPos,spawnRot);
        newBullet.gameObject.SetActive(true);
    }

    protected virtual bool IsShooting()
    {
        this.isShooting = InputManager.Instance.OnFiring == 1;
        return this.isShooting;
    }
}
