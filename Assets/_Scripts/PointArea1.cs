using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointArea1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bird"))
        {
            UIManager.sharedInstance.AddPoint();
        }
    }
}
