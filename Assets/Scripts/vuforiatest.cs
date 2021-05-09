using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class vuforiatest : MonoBehaviour {
    [SerializeField] TrackableBehaviour mTrackableBehaviour;
    [SerializeField] Transform myModelPrefab;
    [SerializeField] VideoPlayer myVideoplayer;
    
    /*public void OnTrackableStateChanged(
    TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus) {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
            OnTrackingFound();
        }
    }
    private void OnTrackingFound()
    {
        if (myModelPrefab != null) {
            Transform myModelTrf = GameObject.Instantiate(myModelPrefab) as Transform;
            myModelTrf.parent = mTrackableBehaviour.transform;
            myModelTrf.localPosition = new Vector3(0f, 0f, 0f);
            myModelTrf.localRotation = Quaternion.identity;
            myModelTrf.localScale = new Vector3(0.0005f, 0.0005f, 0.0005f);
            myModelTrf.gameObject.SetActive(true);
            myVideoplayer.Play();
        }
    }*/

    public void tracking() {
        myVideoplayer.Play();
    }

    public void trackout() {
        myVideoplayer.Pause();
    }
}
