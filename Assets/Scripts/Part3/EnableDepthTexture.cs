using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDepthTexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
        print(GetComponent<Camera>().depthTextureMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
