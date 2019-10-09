using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentObject
{
    private GameObject _gameObject;
    private Transform _transForm;
    public GameObject gameObject
    {
        get
        {
            return _gameObject;
        }

        set
        {
            _gameObject = value;
            _transForm = _gameObject.transform;
        }
    }

    public Transform transForm
    {
        get
        {
            return _transForm;
        }
        set
        {
            _transForm = value;
            _gameObject = _transForm.gameObject;
        }
    }
}
