using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerHolderScript : MonoBehaviour
{

    public static ManagerHolderScript instance = null;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
