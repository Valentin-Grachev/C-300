using UnityEngine;

public class SelectMode_Button : ButtonClick
{
    [SerializeField] private AnimationController.ProcessType _processType;
    [SerializeField] private GameObject _menu;


    protected override void OnClick()
    {
        AnimationController.processType = AnimationController.ProcessType.Closing;
        AnimationController.RunStep(0);
        _menu.SetActive(false);
    }
}
