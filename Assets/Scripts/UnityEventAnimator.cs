using UnityEngine;

public class UnityEventAnimator : MonoBehaviour
{

    // Once again, all fields are private because no outside script needed access. Encapsulate first and expose later only if needed!

    [SerializeField]
    private float m_duration = 1f;

    [SerializeField]
    private Vector3Event[] m_vector3Events = null;

    [SerializeField]
    private FloatEvent[] m_floatEvents = null;

    [SerializeField]
    private ColorEvent[] m_colorEvents = null;

    // yes, Update works if marked as private. Encapsulate first ;)
    private void Update()
    {
        var progress = Mathf.Clamp01(Mathf.PingPong(Time.time, m_duration) / m_duration);
        UpdateEvents(m_vector3Events, progress);
        UpdateEvents(m_floatEvents, progress);
        UpdateEvents(m_colorEvents, progress);
    }

    private void UpdateEvents(BaseEvent[] baseEvents, float progress)
    {
        if (baseEvents != null)
        {
            for (int i = 0; i < baseEvents.Length; i++)
            {
                baseEvents[i].Invoke(progress);
            }
        }
    }

}