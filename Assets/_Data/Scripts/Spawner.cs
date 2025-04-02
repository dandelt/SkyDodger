using System.Collections.Generic;
using UnityEngine;

public class Spawner : DanMonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPrefabs();
    }

    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;
        Transform prefabObjs = transform.Find("Prefabs");
        foreach (Transform obj in prefabObjs)
        {
            this.prefabs.Add(obj);
        }
        this.HidePrefabs();
    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
}
