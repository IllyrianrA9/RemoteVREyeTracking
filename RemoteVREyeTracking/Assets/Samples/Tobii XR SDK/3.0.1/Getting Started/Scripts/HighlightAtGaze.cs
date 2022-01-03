// Copyright © 2018 – Property of Tobii AB (publ) - All Rights Reserved

using System.Collections;
using System.Collections.Generic;
using Tobii.G2OM;
using UnityEngine;
using Tobii.XR;

namespace Tobii.XR.Examples.GettingStarted
{
    //Monobehaviour which implements the "IGazeFocusable" interface, meaning it will be called on when the object receives focus
    public class HighlightAtGaze : MonoBehaviour, IGazeFocusable
    {
        private static readonly int _baseColor = Shader.PropertyToID("_BaseColor");
        public Color highlightColor = Color.red;
        public float animationTime = 0.1f;
        //public Material FocusedMaterial, NonFocusedMaterial;
        //public GameObject Camera;


        private Renderer _renderer;
        private Color _originalColor;
        private Color _targetColor;
        //private Vector3 _heading;
        //private MeshRenderer _meshRenderer;

        //The method of the "IGazeFocusable" interface, which will be called when this object receives or loses focus
        public void GazeFocusChanged(bool hasFocus)
        {
            //If this object received focus, fade the object's color to highlight color
            if (hasFocus)
            {
                _targetColor = highlightColor;
            }
            //If this object lost focus, fade the object's color to it's original color
            else
            {
                _targetColor = _originalColor;
            }
        }

        private void Start()
        {
            //TobiiXR.Start();
            _renderer = GetComponent<Renderer>();
            _originalColor = _renderer.material.color;
            _targetColor = _originalColor;
        }

        //private void OnDisable(){
        //    TobiiXR.Stop();
        //}

        private void Update()
        {
            //RaycastHit rayHit;
            //TODO: _heading = MLEyes.FixationPoint - Camera.transform.position;
            //if (Physics.Raycast(Camera.transform.position, _heading, out rayHit, 10.0f)) {
            //    _meshRenderer.material = FocusedMaterial;
            //}
            //else {
            //    _meshRenderer.material = NonFocusedMaterial; 
            //}


            //This lerp will fade the color of the object
            if (_renderer.material.HasProperty(_baseColor)) // new rendering pipeline (lightweight, hd, universal...)
            {
                _renderer.material.SetColor(_baseColor, Color.Lerp(_renderer.material.GetColor(_baseColor), _targetColor, Time.deltaTime * (1 / animationTime)));
            }
            else // old standard rendering pipline
            {
                _renderer.material.color = Color.Lerp(_renderer.material.color, _targetColor, Time.deltaTime * (1 / animationTime));
            }
        }
    }
}
