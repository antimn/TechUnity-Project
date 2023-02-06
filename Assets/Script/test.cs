using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private int number;
    private float flatNumber = 1.52222f;
    private string stroka = "hello";
    private bool flag = true;
    private bool flag2 = false; 
     
    void Start()
    {
       print(number);
       print(stroka);
       print(flag);
       print(flag2);
       print(flatNumber);
       
       
       if (number > 10)
       {
           print("flag is true");
       }
       else if (number == 10) ;
       {
           print("number == 10");
       
        }
       print(this.gameObject.name);
       gameObject.name = "Level 1";
       
       print((this.gameObject.name));
    }

    // Update is called once per frame
    void Update()
    {
        // print(number);
        // print(stroka);
    }
}
