using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class ray : MonoBehaviour {
    HandModel hand_model;

    Hand leap_hand;
    private LeapProvider provider = null;

    private bool isHit;
    private bool alreadyHit = false;

    GameObject selectedObject;
   // private int row;
    //private int column;

   // private Color previousColour;
   // private Vector3 previousScale;
 
    // Use this for initialization
    void Start () {
        hand_model = GetComponent<HandModel>();
        provider = GetComponent<LeapServiceProvider>();
        leap_hand = hand_model.GetLeapHand();
        if (leap_hand == null) Debug.LogError("No leap_hand founded");

    }

    // Update is called once per frame
	public bool isShow =false;
	void Update () {
        FingerModel finger = hand_model.fingers[1];
        Debug.DrawRay (finger.GetTipPosition(), finger.GetRay().direction, Color.blue);
        RaycastHit hit;

		isHit = Physics.Raycast(finger.GetTipPosition(), finger.GetRay().direction, out hit);

        if (isHit)
        {
           
            if (hit.transform.gameObject.name== "GeoSphere346")
            {
				isShow = !isShow;
				Debug.DrawRay(finger.GetTipPosition(), finger.GetRay().direction, Color.clear);

               /* print("风池（足少阳胆经）【定位】在颈后区，枕骨下，胸锁乳突肌上端与斜方肌上端之间的凹陷中  【解剖】浅层布有枕小神经，枕动静脉的分支和属支。深层有枕大神经。  【针刺层次】皮肤——>皮下组织——>头夹肌——>头半棘肌  【主治】1.头痛，眩晕，失眠，癫痫，中风  2.目赤肿痛，视物不明，鼻塞，鼻窦，鼻渊，耳鸣，咽喉肿痛  3.感冒，热病  4.颈项强痛 ");
               print("【定位】在颈后区，枕骨下，胸锁乳突肌上端与斜方肌上端之间的凹陷中");
                print("【解剖】浅层布有枕小神经，枕动静脉的分支和属支。深层有枕大神经。");
                print("【针刺层次】皮肤——>皮下组织——>头夹肌——>头半棘肌");
                print("【主治】1.头痛，眩晕，失眠，癫痫，中风  2.目赤肿痛，视物不明，鼻塞，鼻窦，鼻渊，耳鸣，咽喉肿痛  3.感冒，热病  4.颈项强痛 ");*/
                //selectedObject = null;
            }
			if (hit.transform.gameObject.name == "GeoSphere347") 
			{
				isShow = !isShow;
			}
            if (selectedObject != null && hit.transform.gameObject == selectedObject)
            {
                alreadyHit = true;
            }

            /*if (selectedObject != null && hit.transform.gameObject != selectedObject)
            {
                alreadyHit = false;
                selectedObject.transform.GetComponent<MeshRenderer>().material.color = previousColour;
                selectedObject.transform.localScale = previousScale;
                selectedObject = hit.transform.gameObject;
            }
            selectedObject = hit.transform.gameObject;
            if (selectedObject != null && !alreadyHit)
            {
                Debug.Log(selectedObject.name);
                selectedObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                MeshRenderer temp = selectedObject.GetComponent<MeshRenderer>();
                previousColour = temp.material.color;
                temp.material.color = Color.red;
            }

            else if (selectedObject != null)
            {
                alreadyHit = false;
                selectedObject.transform.GetComponent<MeshRenderer>().material.color = previousColour;
                selectedObject.transform.localScale = previousScale;
                selectedObject = null;
            }*/

        }



    }
    void OnGUI()
    {
		if (isShow)
        {
				GUIStyle frontstyle = new GUIStyle ();
				frontstyle.normal.textColor = new Color (0, 0, 0);
				frontstyle.normal.background = null;
				frontstyle.wordWrap = enabled;
				frontstyle.fixedWidth = 150;
				frontstyle.fixedHeight = 400;
				GUI.Label (new Rect (70, 230, 400, 400), "风池（足少阳胆经） 【定位】在颈后区，枕骨下，胸锁乳突肌上端与斜方肌上端之间的凹陷中 【解剖】浅层布有枕小神经，枕动静脉的分支和属支。深层有枕大神经。【针刺层次】皮肤——>皮下组织——>头夹肌——>头半棘肌 【主治】1.头痛，眩晕，失眠，癫痫，中风 2.目赤肿痛，视物不明，鼻塞，鼻窦，鼻渊，耳鸣，咽喉肿痛 3.感冒，热病  4.颈项强痛", frontstyle);
				/*if (transform.gameObject.name == "GeoSphere346") 
			{
				GUI.Label (new Rect (70, 230, 400, 400),"hahahahah!!!成功",frontstyle);
			}*/
           // Screen.width * 0.5f, Screen.height * 0.5f,100, 30
                }

    }
    }