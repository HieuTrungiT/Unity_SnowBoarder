using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;

    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
        // L?y componet SurfaceEffector 2D t?i ??i t??ng khác "N?n Tuy?t"
      surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();

    }



    void Update()
    {
        // Thay ??i góc ngiêng c?a nhân v?t
        RotatePlayer();
        // Thay ??i t?c ?? c?a nhân v?t
        RespondToBoost();
    }
    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // "T?ng t?c" thay giá tr? t?i surfaceEffector t?i speed = 30f
            surfaceEffector2D.speed = boostSpeed;
        }else
        {
            // "Gi?m t?c" thay ??i giá tr? t?i surfaceEffector t?i speed = 20f
            surfaceEffector2D.speed = baseSpeed;
        }
        // if we push up , then speed up 
        // otherwise stay at normal speed
        // access the surfacerEffector and change its speed
    }
    void RotatePlayer() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Thay ??i góc nghiêng c?a nhân v?t = 1
            rb2d.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Thay ??i góc nghiêng c?a nhân v?t = -1
            rb2d.AddTorque(-torqueAmount);
        }
    
    }
}
