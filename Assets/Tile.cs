using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Material redMaterial;
    Material defaultMaterial;

    Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        defaultMaterial = renderer.material;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("自分の色を変える");
        renderer.material = redMaterial;

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("自分の色を戻す");
        renderer.material = defaultMaterial;
    }
}
