using System;
using UnityEngine;
using UnityEngine.Events;

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