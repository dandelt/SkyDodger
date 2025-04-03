using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 50f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Transform cam;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if(this.cam != null) return;
        this.cam = Object.FindAnyObjectByType<Camera>().transform;
        Debug.Log(transform.name + ": LoadCamera",gameObject);
    }

    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(this.cam.position, transform.parent.position);
        if (this.distance > this.disLimit) return true;
        return false;
    }
}
