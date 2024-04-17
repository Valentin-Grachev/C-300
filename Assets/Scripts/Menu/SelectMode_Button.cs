using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectMode_Button : ButtonClick
{
    [SerializeField] private AnimationController.ProcessType _processType;
    [SerializeField] private GameObject _menu;
    [SerializeField] private bool _loadScene = false;


    protected override void OnClick()
    {
        AnimationController.processType = _processType;

        if (_loadScene)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        else
        {
            AnimationController.RunStep(0);
            _menu.SetActive(false);
        }
        
    }
}
