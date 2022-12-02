using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixManipulation : MonoBehaviour
{
    [SerializeField]
    Matrix4x4 modelMat = Matrix4x4.identity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = MatrixFunctions.ExtractTranslationFromMatrix(ref modelMat);
        transform.localScale = MatrixFunctions.ExtractScaleFromMatrix(ref modelMat);
        transform.localRotation = MatrixFunctions.ExtractRotationFromMatrix(ref modelMat);
    }
}
