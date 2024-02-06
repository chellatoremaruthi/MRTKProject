using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class XchartRenderController : MonoBehaviour
{
    public GameObject gameObjectControl;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("XchartRenderEnumerator");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator XchartRenderEnumerator()
    {
        yield return new WaitForSeconds(1F);
        gameObjectControl.SetActive(false);
    }


}
