using UnityEngine;

public class DemoController : MonoBehaviour
{

    [SerializeField]
    private Button m_testButton = null;

    private void OnEnable()
    {
        m_testButton.OnClick.AddListener(OnClickEventHandler);
    }

    private void OnDisable()
    {
        m_testButton.OnClick.RemoveListener(OnClickEventHandler);
    }

    public void LogMessage(string message)
    {
        Debug.Log(message);
    }

    private void OnClickEventHandler()
    {
        LogMessage("Click from code");
    }
}
