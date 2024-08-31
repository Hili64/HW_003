using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Now for the first int method: Please write a number:");
        AcceptIfNumber(Convert.ToInt32(Console.ReadLine()));
        Debug.Log("Now for the second int method: How many items do you have? Please write a number between 1 and 3 (or out of that range. I'm not forcing you to obey by my rules)");
        AcceptSwitchNumber(Convert.ToInt32(Console.ReadLine()));
    }
    static void AcceptIfNumber(int number)
    {
        if (number % 2 == 0)
        {
            Debug.Log(number + " is divided by 2. nice");
        }

        else
        {
            Debug.Log(number + " is not divided by 2. not nice");
        }
    }

    //
    static void AcceptSwitchNumber(int number)
    {

        switch (number)
        {
            case 0:
            case 1:
                Debug.Log("You have a sword");
                break;

            case 2:
                Debug.Log("You have a sword and a shield");
                break;

            case 3:
                Debug.Log("You have a sword, a shield and a health potion");
                break;

            default:
                Debug.Log("You have a dog named Luna. Luna is a good dog");
                break;
        }
    }
}
