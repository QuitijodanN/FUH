using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeObjects : MonoBehaviour
{
    public string itemNameNeeded;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        float interaction = Input.GetAxis("Interaction");
        if (interaction != 0)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                List<string> toolList = collision.gameObject.GetComponent<PlayerController>().GetItemList();
                foreach (string tool in toolList)
                {
                    if(tool == itemNameNeeded) this.gameObject.SetActive(false);
                }
                
            }
        }
    }
}