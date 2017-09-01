using System;
using UnityEditor;
using UnityEditor.Events;
using UnityEngine;
using UnityEngine.Events;

[CustomEditor(typeof(Button))]
public class ButtonEditor : Editor
{

    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Auto detect DemoController"))
        {
            var demoController = Component.FindObjectOfType<DemoController>();
            if (demoController == null)
            {
                Debug.LogError("Failed to find demoController");
                return;
            }

            Button editingButton = target as Button;
            var testing = UnityEventBase.GetValidMethodInfo(demoController, "LogMessage", new Type[] { typeof(string) });
            var action = (UnityAction<string>)Delegate.CreateDelegate(typeof(UnityAction<string>), demoController, testing.Name);
            UnityEventTools.AddPersistentListener(editingButton.OnClick, () => { action("test"); });
            EditorUtility.SetDirty(editingButton);
        }

        base.OnInspectorGUI();
    }

}
