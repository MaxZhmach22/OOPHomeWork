using System;
using UnityEngine;
using  UnityEngine.UI;

namespace MyLevel
{
    public sealed class GameController : MonoBehaviour, ICounter
    {
        private InteractiveObject[] _interactiveObjects;
        public float bonusTimer = 15f;
        public Text textbox;
        public bool IsON { get; set; }
        

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
            
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i]; 
 
                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }
                
                if (interactiveObject is IEmision emission)
                {
                    emission.Emision();
                }

                if (interactiveObject is IFLicker flicker)
                {
                    flicker.Flicker();
                }
                


                // if (interactiveObject is IRotation rotation)
                // {
                //     rotation.Rotation();
                // }
            }
        }

        private void FixedUpdate()
        {
            if (IsON) CounterStart();
        }


        public void CounterStart()
        {
            if (bonusTimer > 0)
            {
                bonusTimer -= Time.deltaTime;
                textbox.text = Mathf.Round(bonusTimer).ToString();
            }
            else
            {
                bonusTimer = 15f;
                IsON = false;
                textbox.text = "";
            }
        }
    }

}