using UnityEngine;

public class LineSimulator : MonoBehaviour
{
    public GameObject cueBall;
    //lineRendererComponent
    public GameObject line;
    //カメラの現在位置
    private Vector3 currentCameraPos;
    private LineRenderer lineRenderer;

    // Update is called once per frame
    private void Update()
    {

        Vector3 pos = transform.position;

        //物理運動軌道予測線に必要な変数 
        lineRenderer = line.GetComponent<LineRenderer>();
        currentCameraPos = Camera.main.transform.position;
        currentCameraPos -= pos;
        currentCameraPos *= 1 * -1;
        currentCameraPos.y = 0;

        //物理運動軌道予測線 描写
        lineRenderer.SetPosition(0, cueBall.transform.position);
        lineRenderer.SetPosition(1, currentCameraPos);

        //lineの太さ
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }
}