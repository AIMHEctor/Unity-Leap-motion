using UnityEngine;
using System.Collections;
using Leap.Unity;

public class RTS : MonoBehaviour {

	[SerializeField]
	private PinchDetector _pinchDetectorA;
	public PinchDetector PinchDetectorA {
		get {
			return _pinchDetectorA;
		}
		set {
			_pinchDetectorA = value;
		}
	}

	[SerializeField]
	private PinchDetector _pinchDetectorB;
	public PinchDetector PinchDetectorB {
		get {
			return _pinchDetectorB;
		}
		set {
			_pinchDetectorB = value;
		}
	}
    [SerializeField]
    private Transform _anchor;
    // Use this for initialization
    void Start () {
		GameObject pinchController = new GameObject ("RTS Anchor");
		_anchor = pinchController.transform;
		_anchor.transform.parent = transform.parent;
		transform.parent = _anchor;
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(0, -80 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 80 * Time.deltaTime, 0, Space.Self);
        }
        // TODO rotate and scale based on its original rotate and scale 
       if (_pinchDetectorA.IsHolding && !_pinchDetectorB.IsHolding) {
          //transform.rotation = _pinchDetectorA.Rotation;
          transform.eulerAngles = new Vector3(_pinchDetectorB.Rotation.x, _pinchDetectorB.Rotation.y, _pinchDetectorB.Rotation.z);
           
        }
        //_anchor.rotation
        //Debug.Log (_pinchDetectorA.Rotation);

        //_anchor.transform.Rotate (0, 20 * Time.deltaTime, 0);
        if (_pinchDetectorA.IsHolding && _pinchDetectorB.IsHolding) {
			_anchor.localScale =new Vector3(1,1,1)+Vector3.one *Vector3.Distance (_pinchDetectorA.Position, _pinchDetectorB.Position);
            //_anchor.localScale += Vector3.Distance(_pinchDetectorA.Position, _pinchDetectorB.Position);

		}
	}
}
