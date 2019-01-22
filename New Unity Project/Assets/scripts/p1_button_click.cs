using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1_button_click : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject gameObject_text;
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
            gameObject.GetComponent<Animation>().Play("p1_down");
            gameObject_text.GetComponent<Animation>().Play("p1_tekst");

        }
    }
}
