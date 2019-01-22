using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_click : MonoBehaviour
{

    public GameObject gameObject_text;
    public GameObject gameObject_knopka;
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
            gameObject_knopka.GetComponent<Animation>().Play("p2_down");
            gameObject_text.GetComponent<Animation>().Play("p2_text");

        }
    }
}
