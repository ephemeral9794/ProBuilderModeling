using UnityEngine;
using System.Collections;

[System.Serializable]
//カメラの角度によって顔の輪郭モーフを変えるスクリプト;
//3D感をへらせる気がする;
//自由につかっていいよby雨刻憩;
[UnityEngine.AddComponentMenu("Script/camAngles")]
public partial class camAngles : MonoBehaviour
{
    public Transform camObj;
    public GameObject faceObj;
    public Transform constObj;
    public int moofVal = 20;

	private SkinnedMeshRenderer facemoof;
	private float hAngleR;
    private float hAngleL;
    private float vAngleU;
    private float vAngleD;
    private Vector3 camPos;
    private Vector3 constangles;
    private Vector3 hangles;
    private float hAngle;
    private float vAngle;
    private Vector3 constPos;
    private Quaternion constRot;

    public void Start()
    {
        this.facemoof = (SkinnedMeshRenderer) this.faceObj.GetComponent(typeof(SkinnedMeshRenderer));
    }

    public void Update()
    {
        //ターゲットから角度を算出する;
        this.camPos = this.constObj.transform.InverseTransformPoint(this.camObj.transform.position);
        float hangle = Mathf.Atan2(Mathf.Abs(this.camPos.x), Mathf.Max(Mathf.Abs(this.camPos.z), 0.2f)) * Mathf.Rad2Deg;
        float vangle = Mathf.Atan2(Mathf.Abs(this.camPos.y), Mathf.Max(Mathf.Abs(this.camPos.z), 0.2f)) * Mathf.Rad2Deg;
        this.hAngleR = Mathf.Max(hangle - vangle, 0f);
        this.vAngleU = Mathf.Max(vangle - hangle, 0f);
        this.hAngleR = ((this.hAngleR * this.hAngleR) + 5) / this.moofVal;
        this.vAngleU = ((this.vAngleU * this.vAngleU) + 5) / this.moofVal;
        this.hAngleL = this.hAngleR;
        this.vAngleD = this.vAngleU;
        if (this.camPos.x < 0)
        {
            this.hAngleR = this.hAngleR * -1;
        }
        else
        {
            this.hAngleL = this.hAngleL * -1;
        }
        //顔モーフ番号;
        this.facemoof.SetBlendShapeWeight(45, this.hAngleR);
        this.facemoof.SetBlendShapeWeight(44, this.hAngleL);
        this.facemoof.SetBlendShapeWeight(43, this.vAngleU);
        this.facemoof.SetBlendShapeWeight(43, this.vAngleD);
    }

    public camAngles()
    {
        this.moofVal = 20;
        this.camPos = new Vector3(0f, 0f, 0f);
        this.constangles = new Vector3(0f, 0f, 0f);
        this.hangles = new Vector3(0f, 0f, 180);
        this.constPos = new Vector3(0f, 0f, 0f);
        this.constRot = new Quaternion(0f, 0f, 0f, 0f);
    }

}