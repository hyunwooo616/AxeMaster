using DG.Tweening;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    private Material mat;
    private Color originalEmission;

    void Awake()
    {
        mat = GetComponent<Renderer>().material;
        mat.EnableKeyword("_EMISSION");
        originalEmission = mat.GetColor("_EmissionColor");
    }

    public void Flash()
    {

    }
}
