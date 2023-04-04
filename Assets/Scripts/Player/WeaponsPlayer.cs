using System.Collections.Generic;
using UnityEngine;
using Weapons;

public class WeaponsPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private int pressed = 0;
    private List<IWeaponSystem> _weaponSystems = new();
    
    void Start()
    {
        ArmWeapons();
    }

    private void ArmWeapons()
    {
        foreach (IWeaponSystem weapon in _weaponSystems)
        {
            weapon.Arm();
        }
    }

    public void AddWeapon(IWeaponSystem weaponSystem)
    {
        StopWeapons();
        _weaponSystems.Add(weaponSystem);
        ArmWeapons();
    }

    private void StopWeapons()
    {
        foreach (IWeaponSystem weapon in _weaponSystems)
        {
            weapon.Stop();
        }
    }

    private void Upgrade()
    {
        foreach (IWeaponSystem weapon in _weaponSystems)
        {
            weapon.Upgrade(3.0f, 3.0f, 3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C) && pressed == 0)
        {
            pressed += 1;
            IWeaponSystem weaponSystem = gameObject.transform.GetChild(1).GetComponent<SinBSpawner>();
            gameObject.transform.GetChild(1).GetComponent<SinBSpawner>().gameObject.SetActive(true);
            AddWeapon(weaponSystem);
        }

        if (Input.GetKey(KeyCode.U))
        {
            Upgrade();
        }
    }
}