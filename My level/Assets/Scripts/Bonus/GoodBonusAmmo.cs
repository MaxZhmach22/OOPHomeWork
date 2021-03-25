using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace MyLevel

{
    public sealed class GoodBonusAmmo : InteractiveObject, IFlay
    {
        private GameObject _player;
        private int ammo;
        private Player _playerScript; 
        public float speedFlay = 0.4f;
        public float offset = 1.5f;
        public float _lengthFlay = 0.4f;

        private void Start()
        {
            _player = GameObject.FindWithTag("Player");
            _playerScript = _player.GetComponent<Player>();
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,   offset+Mathf.PingPong(Time.time * speedFlay, _lengthFlay),
                transform.localPosition.z);
        }

        protected override void Interaction()
        {
            ammo = Random.Range(1, 10);
            _playerScript.ammo += ammo;
            Log("Ammo + " + ammo.ToString());
        }
    }
    
}



