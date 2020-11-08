using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorKey : MonoBehaviour
{
    
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane + 0.4f));
        transform.position = position;
    }
}
