using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private Vector2 _menuPosition = new Vector2(0, 60);

    private MainMenu _menuSelection = MainMenu.NewGame;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSelection(-1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeSelection(1);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (_menuSelection == MainMenu.NewGame)
            {
                SceneManager.LoadSceneAsync("Main");
            }
            else if (_menuSelection == MainMenu.Quit)
            {
                Application.Quit();
            }
        }
    }

    public void ChangeSelection(int direction)
    {
        int newSelection = (int)_menuSelection + direction;

        if (newSelection != 0 && newSelection != 1)
            return;

        _menuSelection = (MainMenu)newSelection;
        _rectTransform.anchoredPosition += (_menuPosition * direction);
    }
}

public enum MainMenu
{
    NewGame = 1,
    Quit = 0
}
