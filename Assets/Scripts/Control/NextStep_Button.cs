


public class NextStep_Button : ButtonClick
{
    protected override void OnClick()
    {

        AnimationController.RunStep(AnimationController.currentStepIndex + 1);
    }
}
