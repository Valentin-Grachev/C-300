using System.Collections.Generic;
using UnityEngine;


public class HydroDisable : HydroItem
{
    [SerializeField] private List<GameObject> _disableObjects;


    public override void Animate()
    {
        foreach (var disableObject in _disableObjects)
            disableObject.SetActive(false);

        onAnimated?.Invoke();
    }

    public override void Initialize()
    {
        foreach (var disableObject in _disableObjects)
            disableObject.SetActive(true);
    }


}
