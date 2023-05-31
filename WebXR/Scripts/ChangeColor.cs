using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        ChangeColor();
    }
    
    private void ChangeColor()
    {
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}
