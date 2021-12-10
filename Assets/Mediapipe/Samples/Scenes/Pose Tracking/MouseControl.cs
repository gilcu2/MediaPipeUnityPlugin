using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{

  [SerializeField] private float rotationSpeed=30;
  [SerializeField] private GameObject controled;

  
    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(1))
      {
        var mouseX = Input.GetAxis("Mouse X");
        var mouseY = Input.GetAxis("Mouse Y");

        controled.transform.Rotate(0, -mouseX * rotationSpeed * Time.deltaTime, mouseY * rotationSpeed * Time.deltaTime);
      }
    }
}
