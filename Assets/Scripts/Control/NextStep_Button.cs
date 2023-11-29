


public class NextStep_Button : ButtonClick
{
    protected override void OnClick()
    {
        Control.SetStep(Control.currentStep + 1);
    }
}
