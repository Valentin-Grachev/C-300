using UnityEngine;


public class PreviousStep_Button : ButtonClick
{


    protected override void OnClick()
    {
        int step = Mathf.Max(AnimationController.currentStepIndex - 1, 0);
        AnimationController.RunStep(step);
    }



    private void Update()
    {
        button.interactable = AnimationController.currentStepIndex > 0;
    }


}
