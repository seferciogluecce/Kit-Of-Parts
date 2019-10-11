using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObj : MonoBehaviour
{
    public float Height;
    public float HalfHeight;
    // Start is called before the first frame update
    void Awake()
    {
        Height = GetComponent<MeshRenderer>().bounds.size.y;
        HalfHeight = Height / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
