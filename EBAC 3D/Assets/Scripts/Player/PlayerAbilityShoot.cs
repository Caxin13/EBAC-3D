using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilityShoot : PlayerAbilityBase
{

    public GunBase startingGun;
    public GunBase gun1;
    public GunBase gun2;
    public Transform gunPosition;

    private GunBase _currentGun;

    protected override void Init()
    {
        base.Init();

        CreateGun();

        inputs.Gameplay.Shoot.performed += cts => StartShoot();
        inputs.Gameplay.Shoot.canceled += cts => CancelShoot();
        inputs.Gameplay.SwitchToGun1.performed += cts => SwitchToGun1();
        inputs.Gameplay.SwitchToGun2.performed += cts => SwitchToGun2();

    }

    private void CreateGun()
    {
        _currentGun = Instantiate(startingGun, gunPosition);

        _currentGun.transform.localPosition = _currentGun.transform.localEulerAngles = Vector3.zero;

    }

    private void StartShoot()
    {
        _currentGun.StartShoot();
        Debug.Log("Start Shoot");
    }

    private void CancelShoot()
    {
        Debug.Log("Cancel Shoot");
        _currentGun.StopShoot();

    }

    private void SwitchToGun1()
    {
        _currentGun = Instantiate(gun1, gunPosition);

        _currentGun.transform.localPosition = _currentGun.transform.localEulerAngles = Vector3.zero;

    }

    private void SwitchToGun2()
    {
        _currentGun = Instantiate(gun2, gunPosition);

        _currentGun.transform.localPosition = _currentGun.transform.localEulerAngles = Vector3.zero;

    }

   
}
