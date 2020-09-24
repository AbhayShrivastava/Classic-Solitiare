using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Scaling_13 : MonoBehaviour
{


    Renderer mrenderer;
    // Start is called before the first frame update
    void Start()
    {

        mrenderer = this.gameObject.GetComponent<Renderer>();

        StartCoroutine(Reset_Screen());
    }
    IEnumerator Reset_Screen() {
        yield return new WaitForSeconds(0.1f);
        if (mrenderer.isVisible == false)
        {
            Camera.main.orthographicSize = 5.6f;
        }
    }
    // Update is called once per frame
    void Update()
    {
       // Debug.Log(mrenderer.isVisible);
        
    }
}
