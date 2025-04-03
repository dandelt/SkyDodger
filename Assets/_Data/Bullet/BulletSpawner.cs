using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance => instance;
    public static string bulletOne = "Bullet_1";

    protected override void Awake()
    {
        base.Awake();
        BulletSpawner.instance = this;
    }
    
}
