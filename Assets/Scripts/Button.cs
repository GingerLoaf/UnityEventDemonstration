using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{

    public UnityEvent OnClick;

    private void OnGUI()
    {
        if (GUILayout.Button("Click me"))
        {
            OnClick.Invoke();
        }
    }

}
