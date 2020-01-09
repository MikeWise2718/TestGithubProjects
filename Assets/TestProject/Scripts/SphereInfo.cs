using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInfo : MonoBehaviour
{
    public string version = "V1.0.2";
    public int updatecount = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Version: {version}");
    }

    // Update is called once per frame
    void Update()
    {
        updatecount++;
    }
}
