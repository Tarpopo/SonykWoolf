using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NIghtLight : MonoBehaviour
{
   [SerializeField] private string _outLight;
   [SerializeField] private string _inLight;

   private void OnTriggerEnter2D(Collider2D other)
   {
      other.GetComponent<SpriteRenderer>().sortingLayerName=_inLight;
   }

   private void OnTriggerExit2D(Collider2D other)
   { 
      other.GetComponent<SpriteRenderer>().sortingLayerName=_outLight;
   }
}
