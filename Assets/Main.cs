using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour

{
    private GameObject cubeBlock;
    // Start is called before the first frame update
    void Start()
    {
        if (UnityEngine.Camera.main == null) return;
        var main = UnityEngine.Camera.main;
        main.clearFlags = CameraClearFlags.SolidColor;
        main.backgroundColor = Color.black;
        main.fieldOfView = 60;

        cubeBlock = GameObject.CreatePrimitive((PrimitiveType.Cube));
        var cubeBlockRenderer = cubeBlock.GetComponent<Renderer>();
        cubeBlockRenderer.material.SetColor("_Color", Color.magenta);

    }

    // Update is called once per frame
    void Update()
    {
        cubeBlock.transform.Rotate(65 * Time.deltaTime, 65 * Time.deltaTime,0);
        
    }
}
