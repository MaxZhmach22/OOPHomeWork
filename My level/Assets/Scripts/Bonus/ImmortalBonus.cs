using System;
using System.Collections;
using UnityEditorInternal;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;
using UnityEngine.UI;


namespace MyLevel
{
    public class ImmortalBonus : InteractiveObject, IFlay

    {
        private GameObject _player;
        private int _hp;
        private Player _playerScript;
        private float _counter = 0;
        private Collider _colliderIsOf;
        public float speedFlay = 0.4f;
        public float offset = 1.5f;
        public float _lengthFlay = 0.4f;
        private GameController _gameController;

        private void Start()
        {
            _player = GameObject.FindWithTag("Player");
            _colliderIsOf = _player.GetComponent<Collider>();
            _playerScript = _player.GetComponent<Player>();
            _gameController = _player.GetComponent<GameController>();
            
        }

        protected override void Interaction()
        {
            _gameController.IsON = true;
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,   offset+Mathf.PingPong(Time.time * speedFlay, _lengthFlay),
                transform.localPosition.z);
        }

       
    }
}
