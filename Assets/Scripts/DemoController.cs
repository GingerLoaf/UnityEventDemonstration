using UnityEngine;

public class DemoController : MonoBehaviour
{
    // Private because we don't need to access it from other scripts. SerializeField makes unity render the customization tool in the inspector
    [SerializeField]
    private Button m_testButton = null;

    public void LogMessage(string message)
    {
        Debug.Log(message);
    }

    // yes, OnEnable works if marked as private. Encapsulate first ;)
    private void OnEnable()
    {
        // this is where we are subscribing to the event via script (as opposed to the drag and drop inspector ui)
        m_testButton.OnClick.AddListener(OnClickEventHandler);
    }

    // yes, OnDisable works if marked as private. Encapsulate first ;)
    private void OnDisable()
    {
        // always good form to unsubscribe to ensure "ghost" objects aren't notified later on and so the garbage collector can properly de-allocate memory
        m_testButton.OnClick.RemoveListener(OnClickEventHandler);
    }

    private void OnClickEventHandler()
    {
        LogMessage("Click from code");
    }
}
