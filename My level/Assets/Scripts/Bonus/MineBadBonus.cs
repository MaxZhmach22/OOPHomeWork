using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Effects;

namespace MyLevel
{
    public class MineBadBonus: InteractiveObject, IFLicker
    {
        private Material _material;
        private FirstPersonController _playerScript;
        private GameObject _player;

        private void Start()
        {
            _player = GameObject.FindWithTag("Player");
            _playerScript = _player.GetComponent<FirstPersonController>();
            _material = GetComponent<Renderer>().material;
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

        protected override void Interaction()
        {
            _playerScript._hp = 0;
        }
    }

   
}