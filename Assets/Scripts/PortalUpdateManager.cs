using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalUpdateManager : MonoBehaviour
{
    public List<GameObject> Weapons = new List<GameObject>();
    private int activeIndex;
    public void OnEnable()
    {
        EventsManager.OnKnifePortal += KnifeEnabled;
        EventsManager.OnAxePortal += AxeEnabled;
        EventsManager.OnGunPortal += GunEnabled;
    }

    private void Start()
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(false);
        }
    }

    void ToggleObject(int index)
    {
        for(int i=0; 1<Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(i == index ? !Weapons[i].activeSelf: false);
        }
    }
    private void KnifeEnabled()
    {
        ToggleObject(2);
    }

    private void AxeEnabled()
    {
        ToggleObject(1);
    }

    private void GunEnabled()
    {
        ToggleObject (0);
    }
}
