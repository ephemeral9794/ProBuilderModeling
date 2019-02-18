using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Alicia_moof_Camera : MonoBehaviour
{
    public Transform target;
    private float zoomSpeed;
    private int panSpeed;
    private float distance;
    private float orbitX;
    private float orbitY;
    private float x;
    private float y;
    private float firstdistance;
    private Vector3 firsttagetPos;
    private float firstanglex;
    private float firstangley;
    public float rotationDamping;
    public virtual void Start()
    {
        this.firstdistance = this.distance;
        this.firsttagetPos = this.target.transform.position;
        Vector3 angles = this.transform.eulerAngles;
        this.x = angles.y;
        this.firstanglex = angles.y;
        this.y = angles.x;
        this.firstangley = angles.x;
    }

    public virtual void LateUpdate()
    {
        //zoom
        if (Input.GetMouseButton(1))
        {
            this.distance = this.distance + (Input.GetAxis("Mouse Y") * this.zoomSpeed);
            this.distance = Mathf.Clamp(this.distance, 0.5f, 2);
        }
        else
        {
            this.distance = this.distance - ((this.distance - this.firstdistance) * Time.deltaTime);
        }
        //orbit
        if (Input.GetMouseButton(0))
        {
            this.x = this.x + (Input.GetAxis("Mouse X") * this.orbitX);
            this.y = this.y - (Input.GetAxis("Mouse Y") * this.orbitY);
        }
        else
        {
            this.x = this.x - ((this.x - this.firstanglex) * Time.deltaTime);
            this.y = this.y - ((this.y - this.firstangley) * Time.deltaTime);
        }
         //pan
        this.target.transform.rotation = this.transform.rotation;
        if (Input.GetMouseButton(2))
        {
            float panVal = this.panSpeed * (this.distance / 20);
            if (Input.GetAxis("Mouse Y") != 0)
            {
                this.target.transform.Translate((-Vector3.up * Input.GetAxis("Mouse Y")) * panVal);
                this.transform.Translate((-Vector3.up * Input.GetAxis("Mouse Y")) * panVal);
            }
            if (Input.GetAxis("Mouse X") != 0)
            {
                this.target.transform.Translate((-Vector3.right * Input.GetAxis("Mouse X")) * panVal);
                this.transform.Translate((-Vector3.right * Input.GetAxis("Mouse X")) * panVal);
            }
        }
        else
        {
            this.target.transform.position = target.transform.position - ((target.transform.position - firsttagetPos) * Time.deltaTime);
        }
        Quaternion rotation = Quaternion.Euler(this.y, this.x, 0);
        Vector3 position = (rotation * new Vector3(0f, 0f, -this.distance)) + this.target.position;
        this.target.transform.rotation = rotation;
        this.transform.position = position;
    }

    public Alicia_moof_Camera()
    {
        this.zoomSpeed = 0.5f;
        this.panSpeed = 1;
        this.distance = 0.7f;
        this.orbitX = 17f;
        this.orbitY = 17f;
        this.rotationDamping = 3f;
    }

}