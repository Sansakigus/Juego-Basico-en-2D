using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
[ExecuteInEditMode]
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer sr;
    void Start()
    {
        sr=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.sortingOrder=-(int)(transform.position.y*100);
    }
}
