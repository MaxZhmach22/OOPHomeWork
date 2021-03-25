using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

//Пока не используется. FPS основной player, контроллер TODO

namespace MyLevel
{
    public sealed class Player : IsAlive
    {
        public int hp;
        private int _fullHp = 100;
        public int ammo = 0; 
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;
        private bool _immortal = false;
        private bool _doubleSpeed = false;
        private bool _decreaseSpeed = false;

        public int FullHp
        {
            get => _fullHp;
            set => _fullHp = value;
        }

        private void Start()
        {
            hp = _fullHp;
            isAlive = true;
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (!isAlive)
            {
                Death();
            }
            Move();
        }

        private void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            _rigidbody.AddForce(movement * Speed);
        }
    }
}

