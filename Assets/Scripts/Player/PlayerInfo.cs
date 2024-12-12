using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour, IEntity
{
    [SerializeField] private Transform pointerObject;

    void Start()
    {
        pointerObject = transform.GetChild(0);
    }

    public Quaternion GetRotation()
    {
        return pointerObject.rotation;
    }
}