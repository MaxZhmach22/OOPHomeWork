using UnityEngine;

namespace MyLevel

//Пока не используется. FPS основной player

{
    public abstract class IsAlive : MonoBehaviour
    {
        protected bool isAlive;

        protected virtual void Death()
        {
            Destroy(gameObject, 1);
        }

    }
}