using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public abstract class ButtonClick : MonoBehaviour
{
    protected Button button;


    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();


}
