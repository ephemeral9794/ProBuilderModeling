using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Alicia_moof : MonoBehaviour
{
    public GUISkin skinny;
    public bool guiEnabled;
    public int buttonWidth;
    public int buttonheight;
    private int buttonbetween;
    private int screenwidth;
    private int screenheight;
    private float RsliderVal;
    private float GsliderVal;
    private float BsliderVal;
    private GameObject faceM;
    private GameObject eyeM;
    private GameObject otherM;
    private GameObject other2M;
    private SkinnedMeshRenderer facemoof;
    private SkinnedMeshRenderer eyemoof;
    private SkinnedMeshRenderer othermoof;
    private SkinnedMeshRenderer other2moof;
    public float mouth_a;
    public float mouth_i;
    public float mouth_u;
    public float mouth_e;
    public float mouth_o;
    public float mouth_a2;
    public float mouth_n;
    public float mouth_triangle;
    public float mouth_lambda;
    public float mouth_square;
    public float mouth_wa;
    public float mouth_wa2;
    public float mouth_shock;
    public float mouth_angry;
    public float mouth_smile;
    public float mouth_spear;
    public float mouth_spear2;
    public float mouth_cornerUP;
    public float mouth_cornerDown;
    public float mouth_cornerSpear;
    public float mouth_noTeethUP;
    public float mouth_noTeethDown;
    public float mouth_Tu;
    public float mouth_be;
    public float eye_blink;
    public float eye_smile;
    public float eye_winkL;
    public float eye_winkR;
    public float eye_winkL2;
    public float eye_winkR2;
    public float eye_Calm;
    public float eye_shock;
    public float eye_surprised;
    public float eye_TT;
    public float eye_serious;
    public float eye_hacyu;
    public float eyeblow_serious;
    public float eyeblow_trouble;
    public float eyeblow_smile;
    public float eyeblow_angry;
    public float eyeblow_up;
    public float eyeblow_down;
    public float eyeblow_gather;
    public float face_view;
    public float face_rignt;
    public float face_left;
    public float tongue;
    public float mouth_mortifying;
    public float eye_up;
    //other
    public float other_shy;
    public float eye_h2;
    public float eye_h3;
    public float other_shocked;
    public float other_tear;
    //other02
    public float other_shy2;
    private bool[] mouth_Button;
    private bool[] eye_Button;
    private bool[] eyeblow_Button;
    private bool[] face_Button;
    private bool[] other_Button;
    public virtual void Start()
    {
        this.faceM = GameObject.Find("face");
        this.facemoof = (SkinnedMeshRenderer) this.faceM.GetComponent(typeof(SkinnedMeshRenderer));
        this.eyeM = GameObject.Find("eye");
        this.eyemoof = (SkinnedMeshRenderer) this.eyeM.GetComponent(typeof(SkinnedMeshRenderer));
        this.otherM = GameObject.Find("other");
        this.othermoof = (SkinnedMeshRenderer) this.otherM.GetComponent(typeof(SkinnedMeshRenderer));
        this.other2M = GameObject.Find("other02");
        this.other2moof = (SkinnedMeshRenderer) this.other2M.GetComponent(typeof(SkinnedMeshRenderer));
    }

    public virtual void OnGUI()
    {
        if (this.guiEnabled)
        {
            GUI.skin = this.skinny;
            GUI.contentColor = Color.black;
            //mouth
            this.mouth_Button[0] = GUI.Toggle(new Rect(20, this.buttonbetween, this.buttonWidth, this.buttonheight), this.mouth_Button[0], "あ");
            this.mouth_Button[1] = GUI.Toggle(new Rect(20, this.buttonbetween * 2, this.buttonWidth, this.buttonheight), this.mouth_Button[1], "い");
            this.mouth_Button[2] = GUI.Toggle(new Rect(20, this.buttonbetween * 3, this.buttonWidth, this.buttonheight), this.mouth_Button[2], "う");
            this.mouth_Button[3] = GUI.Toggle(new Rect(20, this.buttonbetween * 4, this.buttonWidth, this.buttonheight), this.mouth_Button[3], "え");
            this.mouth_Button[4] = GUI.Toggle(new Rect(20, this.buttonbetween * 5, this.buttonWidth, this.buttonheight), this.mouth_Button[4], "お");
            this.mouth_Button[5] = GUI.Toggle(new Rect(20, this.buttonbetween * 6, this.buttonWidth, this.buttonheight), this.mouth_Button[5], "あ２");
            this.mouth_Button[6] = GUI.Toggle(new Rect(20, this.buttonbetween * 10, this.buttonWidth, this.buttonheight), this.mouth_Button[6], "ん");
            this.mouth_Button[7] = GUI.Toggle(new Rect(20, this.buttonbetween * 7, this.buttonWidth, this.buttonheight), this.mouth_Button[7], "▲");
            this.mouth_Button[8] = GUI.Toggle(new Rect(20, this.buttonbetween * 8, this.buttonWidth, this.buttonheight), this.mouth_Button[8], "Λ");
            this.mouth_Button[9] = GUI.Toggle(new Rect(20, this.buttonbetween * 9, this.buttonWidth, this.buttonheight), this.mouth_Button[9], "■");
            this.mouth_Button[10] = GUI.Toggle(new Rect(20, this.buttonbetween * 11, this.buttonWidth, this.buttonheight), this.mouth_Button[10], "ワ");
            this.mouth_Button[11] = GUI.Toggle(new Rect(20, this.buttonbetween * 12, this.buttonWidth, this.buttonheight), this.mouth_Button[11], "ワ２");
            this.mouth_Button[12] = GUI.Toggle(new Rect(20, this.buttonbetween * 13, this.buttonWidth, this.buttonheight), this.mouth_Button[12], "驚");
            this.mouth_Button[13] = GUI.Toggle(new Rect(20, this.buttonbetween * 14, this.buttonWidth, this.buttonheight), this.mouth_Button[13], "怒");
            this.mouth_Button[14] = GUI.Toggle(new Rect(20, this.buttonbetween * 15, this.buttonWidth, this.buttonheight), this.mouth_Button[14], "にっこり");
            this.mouth_Button[15] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween, this.buttonWidth, this.buttonheight), this.mouth_Button[15], "にやり");
            this.mouth_Button[16] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 2, this.buttonWidth, this.buttonheight), this.mouth_Button[16], "にやり２");
            this.mouth_Button[17] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 3, this.buttonWidth, this.buttonheight), this.mouth_Button[17], "口角上げ");
            this.mouth_Button[18] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 4, this.buttonWidth, this.buttonheight), this.mouth_Button[18], "口角下げ");
            this.mouth_Button[19] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 5, this.buttonWidth, this.buttonheight), this.mouth_Button[19], "口角広げ");
            this.mouth_Button[20] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 6, this.buttonWidth, this.buttonheight), this.mouth_Button[20], "歯無し上");
            this.mouth_Button[21] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 7, this.buttonWidth, this.buttonheight), this.mouth_Button[21], "歯無し下");
            this.mouth_Button[22] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 8, this.buttonWidth, this.buttonheight), this.mouth_Button[22], "つ");
            this.mouth_Button[23] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 9, this.buttonWidth, this.buttonheight), this.mouth_Button[23], "べ");
            this.mouth_Button[24] = GUI.Toggle(new Rect(this.buttonWidth + 10, this.buttonbetween * 10, this.buttonWidth, this.buttonheight), this.mouth_Button[24], "悔");
            //eye
            this.eye_Button[0] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween, this.buttonWidth, this.buttonheight), this.eye_Button[0], "まばたき");
            this.eye_Button[1] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 2, this.buttonWidth, this.buttonheight), this.eye_Button[1], "にっこり");
            this.eye_Button[2] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 3, this.buttonWidth, this.buttonheight), this.eye_Button[2], "ウインク左");
            this.eye_Button[3] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 4, this.buttonWidth, this.buttonheight), this.eye_Button[3], "ウインク右");
            this.eye_Button[4] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 5, this.buttonWidth, this.buttonheight), this.eye_Button[4], "ウインク左２");
            this.eye_Button[5] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 6, this.buttonWidth, this.buttonheight), this.eye_Button[5], "ウインク右２");
            this.eye_Button[6] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 7, this.buttonWidth, this.buttonheight), this.eye_Button[6], "なごみ");
            this.eye_Button[7] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 8, this.buttonWidth, this.buttonheight), this.eye_Button[7], "＞＜");
            this.eye_Button[8] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 9, this.buttonWidth, this.buttonheight), this.eye_Button[8], "驚き");
            this.eye_Button[9] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 10, this.buttonWidth, this.buttonheight), this.eye_Button[9], "TT");
            this.eye_Button[10] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 11, this.buttonWidth, this.buttonheight), this.eye_Button[10], "まじめ");
            this.eye_Button[11] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 12, this.buttonWidth, this.buttonheight), this.eye_Button[11], "はちゅ目");
            this.eye_Button[12] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 13, this.buttonWidth, this.buttonheight), this.eye_Button[12], "はちゅ目縦");
            this.eye_Button[13] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 14, this.buttonWidth, this.buttonheight), this.eye_Button[13], "はちゅ目横");
            this.eye_Button[14] = GUI.Toggle(new Rect((this.buttonWidth * 2) + 10, this.buttonbetween * 15, this.buttonWidth, this.buttonheight), this.eye_Button[14], "下まぶた上げ");
            //eyeblow
            this.eyeblow_Button[0] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween, this.buttonWidth, this.buttonheight), this.eyeblow_Button[0], "まじめ");
            this.eyeblow_Button[1] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 2, this.buttonWidth, this.buttonheight), this.eyeblow_Button[1], "こまる");
            this.eyeblow_Button[2] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 3, this.buttonWidth, this.buttonheight), this.eyeblow_Button[2], "にっこり");
            this.eyeblow_Button[3] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 4, this.buttonWidth, this.buttonheight), this.eyeblow_Button[3], "おこる");
            this.eyeblow_Button[4] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 5, this.buttonWidth, this.buttonheight), this.eyeblow_Button[4], "上");
            this.eyeblow_Button[5] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 6, this.buttonWidth, this.buttonheight), this.eyeblow_Button[5], "下");
            this.eyeblow_Button[6] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 7, this.buttonWidth, this.buttonheight), this.eyeblow_Button[6], "寄");
            //輪郭 
            this.face_Button[0] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 8, this.buttonWidth, this.buttonheight), this.face_Button[0], "俯瞰煽り");
            this.face_Button[1] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 9, this.buttonWidth, this.buttonheight), this.face_Button[1], "輪郭右");
            this.face_Button[2] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 10, this.buttonWidth, this.buttonheight), this.face_Button[2], "輪郭左");
            this.face_Button[3] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 11, this.buttonWidth, this.buttonheight), this.face_Button[3], "舌");
            //他
            this.other_Button[0] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 12, this.buttonWidth, this.buttonheight), this.other_Button[0], "照れ");
            this.other_Button[1] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 13, this.buttonWidth, this.buttonheight), this.other_Button[1], "照れ2");
            this.other_Button[2] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 14, this.buttonWidth, this.buttonheight), this.other_Button[2], "がーん");
            this.other_Button[3] = GUI.Toggle(new Rect(this.screenwidth - this.buttonWidth, this.buttonbetween * 15, this.buttonWidth, this.buttonheight), this.other_Button[3], "涙");
        }
    }

    public virtual void Update()
    {
        //blink
        this.eye_blink = this.eye_blink > 200 ? Random.Range(-7000, -3000) : this.eye_blink + 10;
        //mouth
        if (this.mouth_Button[0])
        {
            this.mouth_a = Mathf.Min(this.mouth_a + 10, 100);
        }
        else
        {
            this.mouth_a = Mathf.Max(0, this.mouth_a - 10);
        }
        if (this.mouth_Button[1])
        {
            this.mouth_i = Mathf.Min(this.mouth_i + 10, 100);
        }
        else
        {
            this.mouth_i = Mathf.Max(0, this.mouth_i - 10);
        }
        if (this.mouth_Button[2])
        {
            this.mouth_u = Mathf.Min(this.mouth_u + 10, 100);
        }
        else
        {
            this.mouth_u = Mathf.Max(0, this.mouth_u - 10);
        }
        if (this.mouth_Button[3])
        {
            this.mouth_e = Mathf.Min(this.mouth_e + 10, 100);
        }
        else
        {
            this.mouth_e = Mathf.Max(0, this.mouth_e - 10);
        }
        if (this.mouth_Button[4])
        {
            this.mouth_o = Mathf.Min(this.mouth_o + 10, 100);
        }
        else
        {
            this.mouth_o = Mathf.Max(0, this.mouth_o - 10);
        }
        if (this.mouth_Button[5])
        {
            this.mouth_a2 = Mathf.Min(this.mouth_a2 + 10, 100);
        }
        else
        {
            this.mouth_a2 = Mathf.Max(0, this.mouth_a2 - 10);
        }
        if (this.mouth_Button[6])
        {
            this.mouth_n = Mathf.Min(this.mouth_n + 10, 100);
        }
        else
        {
            this.mouth_n = Mathf.Max(0, this.mouth_n - 10);
        }
        if (this.mouth_Button[7])
        {
            this.mouth_triangle = Mathf.Min(this.mouth_triangle + 10, 100);
        }
        else
        {
            this.mouth_triangle = Mathf.Max(0, this.mouth_triangle - 10);
        }
        if (this.mouth_Button[8])
        {
            this.mouth_lambda = Mathf.Min(this.mouth_lambda + 10, 100);
        }
        else
        {
            this.mouth_lambda = Mathf.Max(0, this.mouth_lambda - 10);
        }
        if (this.mouth_Button[9])
        {
            this.mouth_square = Mathf.Min(this.mouth_square + 10, 100);
        }
        else
        {
            this.mouth_square = Mathf.Max(0, this.mouth_square - 10);
        }
        if (this.mouth_Button[10])
        {
            this.mouth_wa = Mathf.Min(this.mouth_wa + 10, 100);
        }
        else
        {
            this.mouth_wa = Mathf.Max(0, this.mouth_wa - 10);
        }
        if (this.mouth_Button[11])
        {
            this.mouth_wa2 = Mathf.Min(this.mouth_wa2 + 10, 100);
        }
        else
        {
            this.mouth_wa2 = Mathf.Max(0, this.mouth_wa2 - 10);
        }
        if (this.mouth_Button[12])
        {
            this.mouth_shock = Mathf.Min(this.mouth_shock + 10, 100);
        }
        else
        {
            this.mouth_shock = Mathf.Max(0, this.mouth_shock - 10);
        }
        if (this.mouth_Button[13])
        {
            this.mouth_angry = Mathf.Min(this.mouth_angry + 10, 100);
        }
        else
        {
            this.mouth_angry = Mathf.Max(0, this.mouth_angry - 10);
        }
        if (this.mouth_Button[14])
        {
            this.mouth_smile = Mathf.Min(this.mouth_smile + 10, 100);
        }
        else
        {
            this.mouth_smile = Mathf.Max(0, this.mouth_smile - 10);
        }
        if (this.mouth_Button[15])
        {
            this.mouth_spear = Mathf.Min(this.mouth_spear + 10, 100);
        }
        else
        {
            this.mouth_spear = Mathf.Max(0, this.mouth_spear - 10);
        }
        if (this.mouth_Button[16])
        {
            this.mouth_spear2 = Mathf.Min(this.mouth_spear2 + 10, 100);
        }
        else
        {
            this.mouth_spear2 = Mathf.Max(0, this.mouth_spear2 - 10);
        }
        if (this.mouth_Button[17])
        {
            this.mouth_cornerUP = Mathf.Min(this.mouth_cornerUP + 10, 100);
        }
        else
        {
            this.mouth_cornerUP = Mathf.Max(0, this.mouth_cornerUP - 10);
        }
        if (this.mouth_Button[18])
        {
            this.mouth_cornerDown = Mathf.Min(this.mouth_cornerDown + 10, 100);
        }
        else
        {
            this.mouth_cornerDown = Mathf.Max(0, this.mouth_cornerDown - 10);
        }
        if (this.mouth_Button[19])
        {
            this.mouth_cornerSpear = Mathf.Min(this.mouth_cornerSpear + 10, 100);
        }
        else
        {
            this.mouth_cornerSpear = Mathf.Max(0, this.mouth_cornerSpear - 10);
        }
        if (this.mouth_Button[20])
        {
            this.mouth_noTeethUP = Mathf.Min(this.mouth_noTeethUP + 10, 100);
        }
        else
        {
            this.mouth_noTeethUP = Mathf.Max(0, this.mouth_noTeethUP - 10);
        }
        if (this.mouth_Button[21])
        {
            this.mouth_noTeethDown = Mathf.Min(this.mouth_noTeethDown + 10, 100);
        }
        else
        {
            this.mouth_noTeethDown = Mathf.Max(0, this.mouth_noTeethDown - 10);
        }
        if (this.mouth_Button[22])
        {
            this.mouth_Tu = Mathf.Min(this.mouth_Tu + 10, 100);
        }
        else
        {
            this.mouth_Tu = Mathf.Max(0, this.mouth_Tu - 10);
        }
        if (this.mouth_Button[23])
        {
            this.mouth_be = Mathf.Min(this.mouth_be + 10, 100);
        }
        else
        {
            this.mouth_be = Mathf.Max(0, this.mouth_be - 10);
        }
        //eye
        if (this.eye_Button[0])
        {
            this.eye_blink = this.eye_blink < 0 ? 0 : Mathf.Min(this.eye_blink + 10, 100);
        }
        if (this.eye_Button[1])
        {
            this.eye_smile = Mathf.Min(this.eye_smile + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_smile = Mathf.Max(0, this.eye_smile - 10);
        }
        if (this.eye_Button[2])
        {
            this.eye_winkL = Mathf.Min(this.eye_winkL + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_winkL = Mathf.Max(0, this.eye_winkL - 10);
        }
        if (this.eye_Button[3])
        {
            this.eye_winkR = Mathf.Min(this.eye_winkR + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_winkR = Mathf.Max(0, this.eye_winkR - 10);
        }
        if (this.eye_Button[4])
        {
            this.eye_winkL2 = Mathf.Min(this.eye_winkL2 + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_winkL2 = Mathf.Max(0, this.eye_winkL2 - 10);
        }
        if (this.eye_Button[5])
        {
            this.eye_winkR2 = Mathf.Min(this.eye_winkR2 + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_winkR2 = Mathf.Max(0, this.eye_winkR2 - 10);
        }
        if (this.eye_Button[6])
        {
            this.eye_Calm = Mathf.Min(this.eye_Calm + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_Calm = Mathf.Max(0, this.eye_Calm - 10);
        }
        if (this.eye_Button[7])
        {
            this.eye_shock = Mathf.Min(this.eye_shock + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_shock = Mathf.Max(0, this.eye_shock - 10);
        }
        if (this.eye_Button[8])
        {
            this.eye_surprised = Mathf.Min(this.eye_surprised + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_surprised = Mathf.Max(0, this.eye_surprised - 10);
        }
        if (this.eye_Button[9])
        {
            this.eye_TT = Mathf.Min(this.eye_TT + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_TT = Mathf.Max(0, this.eye_TT - 10);
        }
        if (this.eye_Button[10])
        {
            this.eye_serious = Mathf.Min(this.eye_serious + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_serious = Mathf.Max(0, this.eye_serious - 10);
        }
        if (this.eye_Button[11])
        {
            this.eye_hacyu = Mathf.Min(this.eye_hacyu + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_hacyu = Mathf.Max(0, this.eye_hacyu - 10);
        }
        //eyeblow
        if (this.eyeblow_Button[0])
        {
            this.eyeblow_serious = Mathf.Min(this.eyeblow_serious + 10, 100);
        }
        else
        {
            this.eyeblow_serious = Mathf.Max(0, this.eyeblow_serious - 10);
        }
        if (this.eyeblow_Button[1])
        {
            this.eyeblow_trouble = Mathf.Min(this.eyeblow_trouble + 10, 100);
        }
        else
        {
            this.eyeblow_trouble = Mathf.Max(0, this.eyeblow_trouble - 10);
        }
        if (this.eyeblow_Button[2])
        {
            this.eyeblow_smile = Mathf.Min(this.eyeblow_smile + 10, 100);
        }
        else
        {
            this.eyeblow_smile = Mathf.Max(0, this.eyeblow_smile - 10);
        }
        if (this.eyeblow_Button[3])
        {
            this.eyeblow_angry = Mathf.Min(this.eyeblow_angry + 10, 100);
        }
        else
        {
            this.eyeblow_angry = Mathf.Max(0, this.eyeblow_angry - 10);
        }
        if (this.eyeblow_Button[4])
        {
            this.eyeblow_up = Mathf.Min(this.eyeblow_up + 10, 100);
        }
        else
        {
            this.eyeblow_up = Mathf.Max(0, this.eyeblow_up - 10);
        }
        if (this.eyeblow_Button[5])
        {
            this.eyeblow_down = Mathf.Min(this.eyeblow_down + 10, 100);
        }
        else
        {
            this.eyeblow_down = Mathf.Max(0, this.eyeblow_down - 10);
        }
        if (this.eyeblow_Button[6])
        {
            this.eyeblow_gather = Mathf.Min(this.eyeblow_gather + 10, 100);
        }
        else
        {
            this.eyeblow_gather = Mathf.Max(0, this.eyeblow_gather - 10);
        }
        if (this.face_Button[0])
        {
            this.face_view = Mathf.Min(this.face_view + 10, 100);
        }
        else
        {
            this.face_view = Mathf.Max(0, this.face_view - 10);
        }
        if (this.face_Button[1])
        {
            this.face_rignt = Mathf.Min(this.face_rignt + 10, 100);
        }
        else
        {
            this.face_rignt = Mathf.Max(0, this.face_rignt - 10);
        }
        if (this.face_Button[2])
        {
            this.face_left = Mathf.Min(this.face_left + 10, 100);
        }
        else
        {
            this.face_left = Mathf.Max(0, this.face_left - 10);
        }
        if (this.face_Button[3])
        {
            this.tongue = Mathf.Min(this.tongue + 10, 100);
        }
        else
        {
            this.tongue = Mathf.Max(0, this.tongue - 10);
        }
        if (this.mouth_Button[24])
        {
            this.mouth_mortifying = Mathf.Min(this.mouth_mortifying + 10, 100);
        }
        else
        {
            this.mouth_mortifying = Mathf.Max(0, this.mouth_mortifying - 10);
        }
        if (this.eye_Button[14])
        {
            this.eye_up = Mathf.Min(this.eye_up + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_up = Mathf.Max(0, this.eye_up - 10);
        }
        if (this.other_Button[0])
        {
            this.other_shy = Mathf.Min(this.other_shy + 10, 100);
        }
        else
        {
            this.other_shy = Mathf.Max(0, this.other_shy - 10);
        }
        if (this.eye_Button[12])
        {
            this.eye_h2 = Mathf.Min(this.eye_h2 + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_h2 = Mathf.Max(0, this.eye_h2 - 10);
        }
        if (this.eye_Button[13])
        {
            this.eye_h3 = Mathf.Min(this.eye_h3 + 10, 100);
            this.eye_blink = Random.Range(-7000, -3000);
        }
        else
        {
            this.eye_h3 = Mathf.Max(0, this.eye_h3 - 10);
        }
        if (this.other_Button[2])
        {
            this.other_shocked = Mathf.Min(this.other_shocked + 10, 100);
        }
        else
        {
            this.other_shocked = Mathf.Max(0, this.other_shocked - 10);
        }
        if (this.other_Button[3])
        {
            this.other_tear = Mathf.Min(this.other_tear + 10, 100);
        }
        else
        {
            this.other_tear = Mathf.Max(0, this.other_tear - 10);
        }
        if (this.other_Button[1])
        {
            this.other_shy2 = Mathf.Min(this.other_shy2 + 10, 100);
        }
        else
        {
            this.other_shy2 = Mathf.Max(0, this.other_shy2 - 10);
        }
        this.facemoof.SetBlendShapeWeight(0, this.mouth_a);
        this.facemoof.SetBlendShapeWeight(1, this.mouth_i);
        this.facemoof.SetBlendShapeWeight(2, this.mouth_u);
        this.facemoof.SetBlendShapeWeight(3, this.mouth_e);
        this.facemoof.SetBlendShapeWeight(4, this.mouth_o);
        this.facemoof.SetBlendShapeWeight(5, this.mouth_a2);
        this.facemoof.SetBlendShapeWeight(6, this.mouth_n);
        this.facemoof.SetBlendShapeWeight(7, this.mouth_triangle);
        this.facemoof.SetBlendShapeWeight(8, this.mouth_lambda);
        this.facemoof.SetBlendShapeWeight(9, this.mouth_square);
        this.facemoof.SetBlendShapeWeight(10, this.mouth_wa);
        this.facemoof.SetBlendShapeWeight(11, this.mouth_wa2);
        this.facemoof.SetBlendShapeWeight(12, this.mouth_shock);
        this.facemoof.SetBlendShapeWeight(13, this.mouth_angry);
        this.facemoof.SetBlendShapeWeight(14, this.mouth_smile);
        this.facemoof.SetBlendShapeWeight(15, this.mouth_spear);
        this.facemoof.SetBlendShapeWeight(16, this.mouth_spear2);
        this.facemoof.SetBlendShapeWeight(17, this.mouth_cornerUP);
        this.facemoof.SetBlendShapeWeight(18, this.mouth_cornerDown);
        this.facemoof.SetBlendShapeWeight(19, this.mouth_cornerSpear);
        this.facemoof.SetBlendShapeWeight(20, this.mouth_noTeethUP);
        this.facemoof.SetBlendShapeWeight(21, this.mouth_noTeethDown);
        this.facemoof.SetBlendShapeWeight(22, this.mouth_Tu);
        this.facemoof.SetBlendShapeWeight(23, this.mouth_be);
        this.facemoof.SetBlendShapeWeight(24, this.eye_blink);
        this.facemoof.SetBlendShapeWeight(25, this.eye_smile);
        this.facemoof.SetBlendShapeWeight(26, this.eye_winkL);
        this.facemoof.SetBlendShapeWeight(27, this.eye_winkR);
        this.facemoof.SetBlendShapeWeight(28, this.eye_winkL2);
        this.facemoof.SetBlendShapeWeight(29, this.eye_winkR2);
        this.facemoof.SetBlendShapeWeight(30, this.eye_Calm);
        this.facemoof.SetBlendShapeWeight(31, this.eye_shock);
        this.facemoof.SetBlendShapeWeight(32, this.eye_surprised);
        this.facemoof.SetBlendShapeWeight(33, this.eye_TT);
        this.facemoof.SetBlendShapeWeight(34, this.eye_serious);
        this.facemoof.SetBlendShapeWeight(35, this.eye_hacyu);
        this.facemoof.SetBlendShapeWeight(36, this.eyeblow_serious);
        this.facemoof.SetBlendShapeWeight(37, this.eyeblow_trouble);
        this.facemoof.SetBlendShapeWeight(38, this.eyeblow_smile);
        this.facemoof.SetBlendShapeWeight(39, this.eyeblow_angry);
        this.facemoof.SetBlendShapeWeight(40, this.eyeblow_up);
        this.facemoof.SetBlendShapeWeight(41, this.eyeblow_down);
        this.facemoof.SetBlendShapeWeight(42, this.eyeblow_gather);
        this.facemoof.SetBlendShapeWeight(43, this.face_view);
        this.facemoof.SetBlendShapeWeight(44, this.face_rignt);
        this.facemoof.SetBlendShapeWeight(45, this.face_left);
        this.facemoof.SetBlendShapeWeight(46, this.tongue);
        this.facemoof.SetBlendShapeWeight(47, this.mouth_mortifying);
        this.facemoof.SetBlendShapeWeight(48, this.eye_up);
        //other
        this.othermoof.SetBlendShapeWeight(0, this.other_shy);
        this.othermoof.SetBlendShapeWeight(1, this.eye_shock);
        this.othermoof.SetBlendShapeWeight(2, this.eye_hacyu);
        this.othermoof.SetBlendShapeWeight(3, this.eye_h2);
        this.othermoof.SetBlendShapeWeight(4, this.eye_h3);
        this.othermoof.SetBlendShapeWeight(5, this.other_shocked);
        this.othermoof.SetBlendShapeWeight(6, this.other_tear);
        //other2
        this.other2moof.SetBlendShapeWeight(0, this.other_shy2);
    }

    public Alicia_moof()
    {
        this.guiEnabled = true;
        this.buttonWidth = 80;
        this.buttonheight = 20;
        this.buttonbetween = this.buttonheight + 5;
        this.screenwidth = Screen.width;
        this.screenheight = Screen.height;
        this.mouth_Button = new bool[25];
        this.eye_Button = new bool[15];
        this.eyeblow_Button = new bool[7];
        this.face_Button = new bool[4];
        this.other_Button = new bool[4];
    }

}