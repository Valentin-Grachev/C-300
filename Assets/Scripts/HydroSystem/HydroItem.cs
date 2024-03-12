using System;
using UnityEngine;

public abstract class HydroItem : MonoBehaviour
{

    public Action onAnimated;

    public abstract void Animate();

    public abstract void Initialize();

}
