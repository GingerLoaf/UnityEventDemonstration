using UnityEngine;

// Provides access to non-accessible fields by the default unity event system
public class UnityEventTransformBinder : MonoBehaviour
{

    public float WorldPositionX
    {
        get { return transform.position.x; }
        set
        {
            var worldPosition = transform.position;
            worldPosition.x = value;
            transform.position = worldPosition;
        }
    }

    public float WorldPositionY
    {
        get { return transform.position.y; }
        set
        {
            var worldPosition = transform.position;
            worldPosition.y = value;
            transform.position = worldPosition;
        }
    }

    public float WorldPositionZ
    {
        get { return transform.position.z; }
        set
        {
            var worldPosition = transform.position;
            worldPosition.z = value;
            transform.position = worldPosition;
        }
    }

    public float LocalPositionX
    {
        get { return transform.localPosition.x; }
        set
        {
            var localPosition = transform.localPosition;
            localPosition.x = value;
            transform.localPosition = localPosition;
        }
    }

    public float LocalPositionY
    {
        get { return transform.localPosition.y; }
        set
        {
            var localPosition = transform.localPosition;
            localPosition.y = value;
            transform.localPosition = localPosition;
        }
    }

    public float LocalPositionZ
    {
        get { return transform.localPosition.z; }
        set
        {
            var localPosition = transform.localPosition;
            localPosition.z = value;
            transform.localPosition = localPosition;
        }
    }

    public float WorldEulerAnglesX
    {
        get { return transform.eulerAngles.x; }
        set
        {
            var localEulerAngles = transform.eulerAngles;
            localEulerAngles.x = value;
            transform.eulerAngles = localEulerAngles;
        }
    }

    public float WorldEulerAnglesY
    {
        get { return transform.eulerAngles.y; }
        set
        {
            var localEulerAngles = transform.eulerAngles;
            localEulerAngles.y = value;
            transform.eulerAngles = localEulerAngles;
        }
    }

    public float WorldEulerAnglesZ
    {
        get { return transform.eulerAngles.z; }
        set
        {
            var localEulerAngles = transform.eulerAngles;
            localEulerAngles.z = value;
            transform.eulerAngles = localEulerAngles;
        }
    }

    public float LocalEulerAnglesX
    {
        get { return transform.localEulerAngles.x; }
        set
        {
            var localEulerAngles = transform.localEulerAngles;
            localEulerAngles.x = value;
            transform.localEulerAngles = localEulerAngles;
        }
    }

    public float LocalEulerAnglesY
    {
        get { return transform.localEulerAngles.y; }
        set
        {
            var localEulerAngles = transform.localEulerAngles;
            localEulerAngles.y = value;
            transform.localEulerAngles = localEulerAngles;
        }
    }

    public float LocalEulerAnglesZ
    {
        get { return transform.localEulerAngles.z; }
        set
        {
            var localEulerAngles = transform.localEulerAngles;
            localEulerAngles.z = value;
            transform.localEulerAngles = localEulerAngles;
        }
    }

    public float LocalScaleX
    {
        get { return transform.localScale.x; }
        set
        {
            var localScale = transform.localScale;
            localScale.x = value;
            transform.localScale = localScale;
        }
    }

    public float LocalScaleY
    {
        get { return transform.localScale.y; }
        set
        {
            var localScale = transform.localScale;
            localScale.y = value;
            transform.localScale = localScale;
        }
    }

    public float LocalScaleZ
    {
        get { return transform.localScale.z; }
        set
        {
            var localScale = transform.localScale;
            localScale.z = value;
            transform.localScale = localScale;
        }
    }

}
