


public class NextStep_Button : ButtonClick
{
    protected override void OnClick()
    {

        AnimationController.RunStep(AnimationController.currentStepIndex + 1);
    }


    private void Update()
    {
        button.interactable = AnimationController.currentStepIndex < AnimationController.stepsQuantity - 1;
    }

}
