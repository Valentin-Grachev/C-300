using UnityEngine.SceneManagement;

public class ToMenu_Button : ButtonClick
{
    protected override void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
