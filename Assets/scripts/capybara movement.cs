using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capybaramovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform tf;
    private static readonly float spead = 1000f;
    private static readonly float jumpPower = 1000f;
    // Start is called before the first frame update;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement;
        xDisplacement = Input.GetAxis("Horizontal") * spead * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
    }
}
