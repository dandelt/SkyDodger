using System;
using UnityEngine;

public abstract class Despawn : DanMonoBehaviour
{
   protected void FixedUpdate()
   {
      this.Despawning();
   }

   protected virtual void Despawning()
   {
      if(!this.CanDespawn()) return;
      this.DespawnObj();
   }

   protected virtual void DespawnObj()
   {
      Destroy(transform.parent.gameObject);
   }
   
   protected abstract bool CanDespawn();
}
