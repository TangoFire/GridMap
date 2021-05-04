using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class Testing : MonoBehaviour
{

    private GridMap grid;


    void Start()
    {
        grid = new GridMap(4, 2, 10f, new Vector3(20,0));


    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
    
   
    
        if (Input.GetMouseButton(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
