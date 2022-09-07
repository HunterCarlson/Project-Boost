using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("Congrats, you finished!");
                break;
            case "Fuel":
                Debug.Log("you picked up fuel");
                break;
            default:
                Debug.Log("Sorry, you blew up!");
                break;
        }
    }
}
