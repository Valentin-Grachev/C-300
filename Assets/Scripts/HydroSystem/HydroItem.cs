using System;
using UnityEngine;
using DG.Tweening;

public abstract class HydroItem : MonoBehaviour
{

    public Action onAnimated;

    public abstract void Animate();


    public void ClearState() => onAnimated = null;


    public abstract void Initialize();

}
