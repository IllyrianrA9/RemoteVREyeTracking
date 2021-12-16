using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.XR;
using UnityEngine.UI;

public class EyeTracking : MonoBehaviour
{
   
    //Main Camera des Projekts
    public GameObject Camera;

    //Material, dass zu unserer Kugel hinzugefuegt wird
    public Material FocusedMaterial, NonFocusedMaterial;
    private bool eyeTrackingStarted = false;

    
    //Fuer das kalkulieren der Richtung wo der Proband hinschaut
    private Vector3 _heading;

    //Wird fuer das Herausgeben des Sphere Material verantwortlich sein
    private MeshRenderer _meshRenderer;
    
    void Start() {
        //Anfangen Input der Augen abzufangen
        TobiiXR.Start();
        eyeTrackingStarted = true;

        //Kugel wird auf 2 Meter vor die Kamera gesetzt
        //transform.position = Camera.transform.position + Camera.transform.forward * 2.0f;
		
        //Get the meshRenderer component
        //_meshRenderer = GetComponent<MeshRenderer>();


    }    
    private void OnDisable() {
        //Eyetracking abbrechen
        TobiiXR.Stop();
        eyeTrackingStarted = false;
    }     

    void Update() {
        //Check whether TobiiXR has any focused objects.
        if (eyeTrackingStarted) {
            //Variable fuer das Abfangen von Daten bei einem Raycast
            //RaycastHit rayHit;

            // Vector wird kalkuliert, der von der Kamera Position zu der Fixation zeigt
            //_heading = GetComponent<GazeRay>();

            // Use the proper material
            // Physics.Raycast castet ein ray von der Kamera Position (Startpunkt) zur Richtung von _heading mit einer Distanz von 10m
            // Daten werden in rayHit Variable gespeichert
            //if (Physics.Raycast(Camera.transform.position, _heading, out rayHit, 10.0f)) {
            //    _meshRenderer.material = FocusedMaterial;
            //}
            //else {
            //    _meshRenderer.material = NonFocusedMaterial; 
            //}
        }
    }
}
