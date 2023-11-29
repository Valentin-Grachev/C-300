

public static class Control
{
    public static int currentStep { get; private set; }

    public delegate void OnStepChanged();
    public static event OnStepChanged onStepChanged;

    public static void SetStep(int step)
    {
        currentStep = step;
        onStepChanged?.Invoke();
    }


}
