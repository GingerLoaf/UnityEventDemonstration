using UnityEngine;

// Provides access to non-accessible fields by the default unity event system
public class UnityEventMaterialBinder : MonoBehaviour
{

    [SerializeField]
    private Material m_material = null;

    public Color Color
    {
        get { return m_material.color; }
        set { m_material.color = value; }
    }

}
