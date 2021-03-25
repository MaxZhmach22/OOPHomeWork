using System.Numerics;
using UnityEngine;
using static UnityEngine.Debug;
using Vector3 = UnityEngine.Vector3;

namespace MyLevel
{
    public class HealthSupplyBonus: InteractiveObject, IFlay, IEmision

    {
        private Material _material;
        private GameObject _player;
        private int _hp;
        private Player _playerScript;
        public float speedFlay = 0.4f;
        public float offset = 1.5f;
        public float _lengthFlay = 0.4f;

        private void Start()
        {
            
            _player = GameObject.FindWithTag("Player");
            _playerScript = _player.GetComponent<Player>();
            _material = GetComponent<Renderer>().material;
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,   offset+Mathf.PingPong(Time.time * speedFlay, _lengthFlay),
                transform.localPosition.z);
        }

        protected override void Interaction()
        {
            _hp = Random.Range(1, 10);
            _playerScript.hp += _hp;
            Log("Health + " + _hp.ToString());
            if (_playerScript.hp > _playerScript.FullHp)
            {
                _playerScript.hp = _playerScript.FullHp;
            }
        
        }

        public void Emision()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }
    }
}