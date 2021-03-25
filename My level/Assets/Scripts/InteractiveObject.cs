using System;
using UnityEngine;

namespace MyLevel
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction ();
                Destroy(gameObject);
            }
        }
        protected abstract void Interaction ();
    }
    
}