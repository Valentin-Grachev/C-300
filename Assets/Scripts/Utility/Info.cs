using UnityEngine;

public abstract class Info : MonoBehaviour
{

    protected virtual void OnEnable()
    {
        Subscribe();
        UpdateValue();
    }

    protected virtual void OnDisable()
    {
        Unsubscribe();
    }



    protected abstract void UpdateValue();

    protected abstract void Subscribe();

    protected abstract void Unsubscribe();


}
