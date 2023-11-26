using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "NPC"){
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.name == "NPC"){
            collision.gameObject.transform.SetParent(null);
        }
    }
}
