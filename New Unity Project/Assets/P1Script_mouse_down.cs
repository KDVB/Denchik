using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Script_mouse_down : MonoBehaviour
{

    public GameObject gameObject_text;
    public GameObject gameObject_knopka1;
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
            gameObject_knopka1.GetComponent<Animation>().Play("p1_down");
           // gameObject_text.GetComponent<Animation>().Play("p1_tekst");

        }
    }
}
