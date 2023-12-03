

using UnityEngine;

public class PreviousStep_Button : ButtonClick
{
    protected override void OnClick()
    {
        Control.SetStep(Mathf.Max(Control.currentStep - 1, 0));
    }
}
