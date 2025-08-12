using Marriuss.SmartLogger.API;
using UnityEngine;
using UnityEngine.UI;

public class SampleCanvas : MonoBehaviour
{
    [SerializeField] private Button _infoButton;
    [SerializeField] private Button _successButton;
    [SerializeField] private Button _warningButton;
    [SerializeField] private Button _errorButton;

    private void OnEnable() => AddListeners();
    private void OnDisable() => RemoveListeners();

    private void OnInfoButtonClicked() => Log.Info("This is info message.");
    private void OnSuccessButtonClicked() => Log.Success("This is success message.");
    private void OnWarningButtonClicked() => Log.Warning("This is warning message.");
    private void OnErrorButtonClicked() => Log.Error("This is error message.");

    private void AddListeners()
    {
        _infoButton.onClick.AddListener(OnInfoButtonClicked);
        _successButton.onClick.AddListener(OnSuccessButtonClicked);
        _warningButton.onClick.AddListener(OnWarningButtonClicked);
        _errorButton.onClick.AddListener(OnErrorButtonClicked);
    }

    private void RemoveListeners()
    {
        _infoButton.onClick.RemoveListener(OnInfoButtonClicked);
        _successButton.onClick.RemoveListener(OnSuccessButtonClicked);
        _warningButton.onClick.RemoveListener(OnWarningButtonClicked);
        _errorButton.onClick.RemoveListener(OnErrorButtonClicked);
    }
}
