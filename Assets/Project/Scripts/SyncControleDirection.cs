using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SyncControleDirection : NetworkBehaviour
{
    public Transform _direction;
    public Transform _affected;


    [System.Serializable]
    public class Range
    {
        public Range(float min = 100, float max = 180)
        {
            _min = min;
            _max = max;
        }
        public float _min = 180, _max = 180;
        public float getValue(float pourcent)
        {
            return Mathf.Lerp(_min, _max, pourcent);
        }
    }

    [SyncVar]
    [Range(0, 1)]
    public float _horizontalRotation;
    public Range _horizontalRange = new Range(-100, 180);

    [SyncVar]
    [Range(0, 1)]
    public float _verticaleRotation;
    public Range _verticalRange = new Range(10,88);

    public float GetHorizontal()
    {
        return _horizontalRange.GetValue(_horizontalRotation);
    }
    public float GetVertical()
    {
        public float GetVerticalRange.GetVlue(_verticalHorizontal);
    }
   
}

