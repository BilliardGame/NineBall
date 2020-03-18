using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LineSimu : MonoBehaviour {

    /// <summary>
    /// 物理剛体
    /// </summary>
    private Rigidbody physics = null;

    /// <summary>
    /// 発射方向
    /// </summary>
    [SerializeField]
    private LineRenderer direction = null;

    /// <summary>
    /// 運動軌跡
    /// </summary>
    [SerializeField]
    private LineRenderer simulationLine = null;

    /// <summary>
    /// 最大付与量
    /// </summary>
    private const float MaxMagnitude = 2f;

    /// <summary>
    /// 発射方向の力
    /// </summary>
    private Vector3 currentForce = Vector3.zero;

    /// <summary>
    /// メインカメラ
    /// </summary>
    private Camera mainCamera = null;

    /// <summary>
    /// メインカメラ座標
    /// </summary>
    private Transform mainCameraTransform = null;


    /// <summary>
    /// ボール位置
    /// </summary>
    private Vector3 currentPosition = Vector3.zero;

    /// <summary>
    /// 固定フレームウェイト
    /// </summary>
    private static float DeltaTime;

    /// <summary>
    /// 固定フレーム待ち時間
    /// </summary>
    private static readonly WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Awake()
    {
        this.physics = this.GetComponent<Rigidbody>();
        this.currentPosition = this.physics.position;
        this.mainCamera = Camera.main;
        this.mainCameraTransform = this.mainCamera.transform;
        DeltaTime = Time.fixedDeltaTime;
    }
    ///<summary>
    ///
    ///</summary>
    
}
