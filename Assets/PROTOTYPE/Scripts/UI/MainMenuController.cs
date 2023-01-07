using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuController : MonoBehaviour
{
    private UIDocument _doc;

    private Button _buttonNewGame;
    private Button _buttonContinueGame;
    private Button _buttonSettings;
    private Button _buttonInfo;
    private Button _buttonExit;

    private VisualElement _buttonsWrapper;

    [SerializeField]
    private VisualTreeAsset _settingsButtonsTemplate;
    private VisualElement _settingsButtons;

    private void Awake()
    {
        _doc = GetComponent<UIDocument>();

        _buttonNewGame = _doc.rootVisualElement.Q<Button>("ButtonNewGame");
        _buttonContinueGame = _doc.rootVisualElement.Q<Button>("ButtonContinueGame");
        _buttonSettings = _doc.rootVisualElement.Q<Button>("ButtonSettings");
        _buttonInfo = _doc.rootVisualElement.Q<Button>("ButtonInfo");
        _buttonExit = _doc.rootVisualElement.Q<Button>("ButtonExit");

        _buttonsWrapper = _doc.rootVisualElement.Q<VisualElement>("ButtonPanel");

        _settingsButtons = _settingsButtonsTemplate.CloneTree();
        var buttonBackToMainMenu = _settingsButtons.Q<Button>("ButtonBackToMainMenu");
        buttonBackToMainMenu.clicked += ButtonBackToMainMenuClicked;

        _buttonNewGame.clicked += ButtonNewGameClicked;
        _buttonContinueGame.clicked += ButtonContinueGameClicked;
        _buttonSettings.clicked += ButtonSettingsClicked;
        _buttonInfo.clicked += ButtonInfoClicked;
        _buttonExit.clicked += ButtonExitClicked;
    }

    private void ButtonNewGameClicked()
    {

    }

    private void ButtonContinueGameClicked()
    {

    }

    private void ButtonSettingsClicked()
    {
        _buttonsWrapper.Clear();
        _buttonsWrapper.Add(_settingsButtons);
    }

    private void ButtonBackToMainMenuClicked()
    {
        _buttonsWrapper.Clear();
        _buttonsWrapper.Add(_buttonNewGame);
        _buttonsWrapper.Add(_buttonContinueGame);
        _buttonsWrapper.Add(_buttonSettings);
        _buttonsWrapper.Add(_buttonInfo);
        _buttonsWrapper.Add(_buttonExit);
    }

    private void ButtonInfoClicked()
    {

    }

    private void ButtonExitClicked()
    {
        Application.Quit();
    }
}