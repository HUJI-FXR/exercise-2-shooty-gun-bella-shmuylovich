using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    #region MONOBEJAVIOUR

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - transform.position).normalized;
        float rot = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    #endregion

    
    
}
