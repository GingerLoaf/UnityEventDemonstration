using UnityEngine;

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
