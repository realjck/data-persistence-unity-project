using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance != null){
            GetComponent<MeshRenderer>().material = GameManager.Instance.backgroundMaterial;
        }
    }
}
