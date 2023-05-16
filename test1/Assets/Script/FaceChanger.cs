using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceChanger : MonoBehaviour
{
    public Renderer faceRenderer;
    public string newTextureName = "Dino_Face19";
    private void Update()
    {
        Texture newTexture = Resources.Load<Texture>("Face/" + newTextureName);
        Debug.Log(newTexture);
        Material faceMaterial = faceRenderer.material;
        faceMaterial.mainTexture = newTexture;
    }
}
