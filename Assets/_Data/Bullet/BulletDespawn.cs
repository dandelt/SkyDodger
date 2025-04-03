using UnityEngine;

public class BulletDespawn : DespawnByDistance
{
   protected override void DespawnObj()
   {
      BulletSpawner.Instance.Despawn(transform.parent);
   }
}
