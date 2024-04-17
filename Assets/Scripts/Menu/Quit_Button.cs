using UnityEngine;

public class Quit_Button : ButtonClick
{
    protected override void OnClick()
    {
        Application.Quit();
    }
}
