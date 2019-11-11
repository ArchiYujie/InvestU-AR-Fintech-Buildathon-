using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTestScale : MonoBehaviour
{
    // declare variables or instance field
    public GameObject objectToScale;
    public Slider scaleSlider;

    // declare the previous value of the slider
    private float previousValue;

    //we start our updates

    // Start is called before the first frame update
    void Awake()
    {
        scaleSlider = GameObject.FindGameObjectWithTag("ScaleSlider").GetComponent<Slider>();
        objectToScale = GameObject.FindGameObjectWithTag("City");

        // assign callback for when the value is changed
        this.scaleSlider.onValueChanged.AddListener(this.OnSliderChanged);

        // And current value
        this.previousValue = this.scaleSlider.value;
    }

    // Update is called once per frame
    void OnSliderChanged(float value)
    {
        // How much we've changed
        float delta = value - this.previousValue;
        this.objectToScale.transform.localScale = new Vector3(delta * 1f, delta * 1, delta * 1f);

        // Set our previous value for the next change
        // this.previousValue = value;

    }
}
