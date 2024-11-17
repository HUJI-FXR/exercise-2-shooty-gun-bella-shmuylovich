using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ShootyGunScript : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed;

    #endregion

    #region MONOBEHAVIOUR

    void Update()
    {
        CheckInput();
    }

    #endregion
   

    #region HELPERS

    private void CheckInput()
    {
        if (Input.GetMouseButtonUp(0)) Shoot();
    }

    private void Shoot()
    {
        GameObject shot = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);
        shot.SetActive(true);
        shot.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed * Time.deltaTime;
    }

    #endregion
}
