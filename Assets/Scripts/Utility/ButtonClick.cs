using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public abstract class ButtonClick : MonoBehaviour
{

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();


}
