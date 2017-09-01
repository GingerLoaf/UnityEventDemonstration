using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventAnimator : MonoBehaviour
{

    [SerializeField]
    private float m_duration = 1f;

    [SerializeField]
    private Vector3Event[] m_vector3Events = null;

    [SerializeField]
    private FloatEvent[] m_floatEvents = null;

    [SerializeField]
    private ColorEvent[] m_colorEvents = null;

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

[Serializable]
public class Vector3Event : BaseEvent
{
    public Vector3 Min = Vector3.zero;
    public Vector3 Max = Vector3.one;
    public UnityVector3Event Event = null;

    public override void Invoke(float fraction)
    {
        Event.Invoke(Vector3.Lerp(Min, Max, GetAnimatedFraction(fraction)));
    }
}

[Serializable]
public class FloatEvent : BaseEvent
{
    public float Min = 0;
    public float Max = 1f;
    public UnityFloatEvent Event = null;

    public override void Invoke(float fraction)
    {
        Event.Invoke(Mathf.Lerp(Min, Max, GetAnimatedFraction(fraction)));
    }
}

[Serializable]
public class ColorEvent : BaseEvent
{
    public Color Min = Color.white;
    public Color Max = Color.black;
    public UnityColorEvent Event = null;

    public override void Invoke(float fraction)
    {
        Event.Invoke(Color.Lerp(Min, Max, GetAnimatedFraction(fraction)));
    }
}

public abstract class BaseEvent
{

    [SerializeField]
    private AnimationCurve m_animationCurve = null;

    protected float GetAnimatedFraction(float fraction)
    {
        return m_animationCurve.Evaluate(fraction);
    }

    public abstract void Invoke(float fraction);
}

[Serializable]
public class UnityVector3Event : UnityEvent<Vector3> { }

[Serializable]
public class UnityFloatEvent : UnityEvent<float> { }

[Serializable]
public class UnityColorEvent : UnityEvent<Color> { }