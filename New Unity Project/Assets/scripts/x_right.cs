using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x_right : MonoBehaviour
{
    public GameObject gameObject_xrest;
    public GameObject gameObject_to_the;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject_xrest.GetComponent<Animation>().Play("HREST");
            gameObject_to_the.GetComponent<Animation>().Play("x_right");
        }
    }
}
