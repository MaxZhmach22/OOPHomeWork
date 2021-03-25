using UnityEngine;

namespace MyLevel

//Пока не используется. Будет проверка на состояние объекта, если мертвый, играем анимацию.

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