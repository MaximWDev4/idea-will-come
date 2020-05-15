﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float backgroundSize;
    public float parallaxSpeed;

    private Transform camera;
    private Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraX;
    private void Start() {
        camera = Camera.main.transform;
        lastCameraX =camera.position.x;
        layers = new Transform[transform.childCount];
        for(int i=0; i<transform.childCount; i++)
        {
            layers[i] = transform.GetChild(i);
        }    
        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }

    private void Update() {
        float deltaX =camera.position.x - lastCameraX;
        transform.position += Vector3.right * (deltaX * parallaxSpeed);
        lastCameraX =camera.position.x;
        if(camera.position.x < (layers[leftIndex].transform.position.x + viewZone)){
            ScrollLeft();
        }
        if(camera.position.x > (layers[rightIndex].transform.position.x - viewZone)){
            ScrollRight();
        }
    }
    private void ScrollLeft(){
       int lastRight = rightIndex;
       layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize);
       leftIndex = rightIndex;
       rightIndex--;
       if(rightIndex < 0){
           rightIndex = layers.Length - 1;
       }
    }    
    private void ScrollRight(){
       int lastleft = leftIndex;
       layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
       rightIndex = leftIndex;
       leftIndex++;
       if(leftIndex == layers.Length){
           leftIndex = 0;
       }
    }  
}