using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_script_right : MonoBehaviour
{
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
            gameObject.GetComponent<Animation>().Play("on");
        }
    }
}
