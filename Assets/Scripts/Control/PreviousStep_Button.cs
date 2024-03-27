

using UnityEngine;

public class PreviousStep_Button : ButtonClick
{
    protected override void OnClick()
    {
        int step = Mathf.Max(AnimationController.currentStepIndex - 1, 1);
        AnimationController.RunStep(step);
    }
}
