using SoundlightInteractive.EventSystem;

namespace SoundlightInteractive.Manager
{
    public abstract class Manager<T> : Actor where T : Actor 
    {
        public static T Instance { get; private set; }

        protected virtual void Awake() => Instance = this as T;

        protected virtual void OnApplicationQuit()
        {
            Instance = null;
            Destroy(gameObject);
        }
    }
}