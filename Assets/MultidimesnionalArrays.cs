using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[,] nameRole = { { "John", "Tutor" }, { "Connah", "Tutor" }, { "Matthew", "Tutor" } };
        for (int i = 0; i < nameRole.GetLength(0); i++)
        {
            for (int j = 0; j < nameRole.GetLength(1); j++)
            {
                Debug.Log(nameRole[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
