using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockOnTrigger2D : MonoBehaviour
{
    enum Limit {Left,Right,Top,Buttom}

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag = "Player";
    [Tooltip("Defiance against the wall")]
    [SerializeField] float defiance = 0.5f;
    [Tooltip("Wall in left,right,top or button")]
    [SerializeField] Limit limit;
    private void OnTriggerEnter2D(Collider2D other) {       
        if (other.tag == triggeringTag && enabled) {
            switch (limit)
            {
                case Limit.Top:
                    other.gameObject.transform.position += Vector3.down * defiance;
                    break;
                case Limit.Buttom:
                    other.gameObject.transform.position += Vector3.up * defiance;
                    break;
                case Limit.Left:
                    other.gameObject.transform.position += Vector3.right * defiance;
                    break;
                case Limit.Right:
                    other.gameObject.transform.position += Vector3.left * defiance;
                    break;                
            }
           
        }
    }
}
