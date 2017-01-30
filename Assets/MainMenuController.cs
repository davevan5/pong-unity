using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    private int _menuSelectionState = 0;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            switch (_menuSelectionState)
            {
                case 0:
                    _rectTransform.anchoredPosition = new Vector2(-100, -30);
                    _menuSelectionState = 1;
                    return;
                case 1:
                    _rectTransform.anchoredPosition = new Vector2(-100, 0);
                    _menuSelectionState = 0;
                    return;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            switch (_menuSelectionState)
            {
                case 0:
                    _rectTransform.anchoredPosition = new Vector2(-100, -30);
                    _menuSelectionState = 1;
                    return;
                case 1:
                    _rectTransform.anchoredPosition = new Vector2(-100, 0);
                    _menuSelectionState = 0;
                    return;
            }
        }
    }
}
