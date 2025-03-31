using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;
    [SerializeField] protected Vector3 targetPos;
    [SerializeField] protected float edgePadding = 0.3f;
    void FixedUpdate()
    {
        this.GetTargetPosition();
        this.Moving();
    }

    protected virtual void GetTargetPosition()
    {
        this.targetPos = InputManager.Instance.MouseWorldPos;
        this.targetPos = ClampToScreenBounds(this.targetPos, this.edgePadding);
        this.targetPos.z = 0;
    }
    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, this.targetPos, this.speed * Time.fixedTime);
        transform.parent.position = newPos;
    }
    
    protected virtual Vector3 ClampToScreenBounds(Vector3 pos, float edgePadding)
    {
        Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        pos.x = Mathf.Clamp(pos.x, min.x + edgePadding, max.x - edgePadding);
        pos.y = Mathf.Clamp(pos.y, min.y + edgePadding, max.y - edgePadding);
        return pos;
    }
}
