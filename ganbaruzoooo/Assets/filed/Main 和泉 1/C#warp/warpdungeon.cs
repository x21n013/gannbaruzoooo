using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpdungeon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public Vector3 pos;
    private string answerTag = "Player";
 
    private void OnCollisionEnter(Collision dungeon1)
    {
    if (this.gameObject.CompareTag(answerTag)){
        dungeon1.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }else{

    }
    }
}
