using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctons : MonoBehaviour
{
    //Create a variable of ty[e int and set it to number 5
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}