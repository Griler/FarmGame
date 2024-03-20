using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandManager : MonoBehaviour
{
    private List<GameObject> landList = new List<GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            landList.Add(transform.GetChild(i).gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}