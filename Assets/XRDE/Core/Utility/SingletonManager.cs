// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T>
{
    private static T _instance;
    private static bool _isNullInstance = true;
    protected bool _isDirty = false;

    public static T Instance
    {
        get
        {
            if (_instance == null && _isNullInstance)
            {
                _isNullInstance = false;
                T[] objects = FindObjectsOfType<T>();
                if (objects.Length == 0)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    _instance = singleton.AddComponent<T>();
                }
                else if (objects.Length == 1)
                {
                    _instance = objects[0];
                }
                else if (objects.Length > 1)
                {
                    Debug.LogErrorFormat("There's {0} [{1}] instance.", objects.Length, typeof(T).ToString());
                }
            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (IsInitialized && _instance != this)
        {
            _isDirty = true;
            DestroyImmediate(this.gameObject);
            Debug.LogFormat("Additional [{0}] instance was destroyed.", GetType().Name);
        }
        else
        {
            _instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
            _isNullInstance = true;
        }
    }

    public static bool IsInitialized
    {
        get
        {
            return _instance != null;
        }
    }
}

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance;
    private static bool _isNullInstance = true;
    protected bool _isDirty = false;

    public static T Instance
    {
        get
        {
            if (_instance == null && _isNullInstance)
            {
                _isNullInstance = false;
                T[] objects = FindObjectsOfType<T>();
                if (objects.Length == 0)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    _instance = singleton.AddComponent<T>();
                }
                else if (objects.Length == 1)
                {
                    _instance = objects[0];
                }
                else if (objects.Length > 1)
                {
                    Debug.LogErrorFormat("There's {0} [{1}] instance.", objects.Length, typeof(T).ToString());
                }
            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (IsInitialized && _instance != this)
        {
            _isDirty = true;
            //DestroyImmediate(this.gameObject);
            Debug.LogFormat("Additional [{0}] instance was destroyed.", GetType().Name);
        }
        else
        {
            _instance = this as T;
            //DontDestroyOnLoad(this.gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
            _isNullInstance = true;
        }
    }

    public static bool IsInitialized
    {
        get
        {
            return _instance != null;
        }
    }
}