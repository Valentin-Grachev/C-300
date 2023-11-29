

public class PreviousStep_Button : ButtonClick
{
    protected override void OnClick()
    {
        Control.SetStep(Control.currentStep + 1);
    }
}
