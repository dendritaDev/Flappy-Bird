using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 0f;

    private Rigidbody2D _rigidbody;

    public float switchTime = 2f;

    private float distanceToDestroy = 42f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.up * speed;
        InvokeRepeating(nameof(SwitchMovement), 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        float xcam = Camera.main.transform.position.x;
        float xpipe = this.transform.position.x;

        if(xcam > xpipe + distanceToDestroy)
        {
            Destroy(this.gameObject);
        }
    }

    void SwitchMovement()
    {
        _rigidbody.velocity *= -1;
    }
}
