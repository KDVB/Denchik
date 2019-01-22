using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_BB : MonoBehaviour
{
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
            gameObject_knopka.GetComponent<Animation>().Play("right_big_animation");

        }
    }
}

