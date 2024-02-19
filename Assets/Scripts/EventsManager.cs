using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static EventsManager instance;
    public static EventsManager Instance
    {
        get => instance;
    }

    public delegate void PortalEvent();
    public static event PortalEvent OnKnifePortal = delegate { };
    public static event PortalEvent OnAxePortal = delegate { };
    public static event PortalEvent OnGunPortal = delegate { };

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    public void KnifePortal()
    {
        OnKnifePortal?.Invoke();
    }

    public void AxePortal()
    {
        OnAxePortal?.Invoke();
    }

    public void GunPortal() 
    { 
        OnAxePortal.Invoke();
    }
}
