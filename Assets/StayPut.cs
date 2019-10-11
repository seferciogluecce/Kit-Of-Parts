using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayPut : MonoBehaviour
{
    GameObject BaseObj; 

    // Start is called before the first frame update
    void Start()
    {
        BaseObj = GameObject.FindObjectOfType<BaseObj>().gameObject;

        Vector3 CurPos = transform.position;
        this.transform.position = new Vector3(CurPos.x, BaseObj.GetComponent<BaseObj>().HalfHeight +  GetComponent<MeshRenderer>().bounds.extents.y  , CurPos.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
