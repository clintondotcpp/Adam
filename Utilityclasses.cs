using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreateObjects(;)
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.SetPosToZero(this.gameObject);
        }
    }
}

// 2nd Script

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{

    public static void CreateObjects()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPosToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }
}
