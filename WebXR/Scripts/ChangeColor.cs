using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    Renderer _mat;

    void Start()
    {
        _mat = GetComponent<Renderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        ChangeColor();
    }
    
    private void ChangeColor()
    {
        _mat.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

}
