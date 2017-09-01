using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{

    // Since UnityEvent is serializable, it will render a drag and drop ui in the inspector
    public UnityEvent OnClick;

    // yes, OnGUI works if marked as private. Encapsulate first ;)
    private void OnGUI()
    {
        if (GUILayout.Button("Click me"))
        {
            // Invoke is our "publish". Any subscribers will be notified whether they subscribed through serialization or scripts
            OnClick.Invoke();
        }
    }

}
