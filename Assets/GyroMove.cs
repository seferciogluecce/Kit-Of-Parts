using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour
{

    GameObject gParent;
    // Start is called before the first frame update
    void Start()
    {
        gParent = new GameObject();
        gParent.transform.position = transform.position;
        gParent.transform.rotation = transform.rotation;
        transform.SetParent(gParent.transform);
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gyro = Input.gyro.rotationRateUnbiased;
        gParent.transform.Rotate(0, -gyro.y, 0);

         transform.Rotate(-gyro.x, 0, 0);

    }
}
