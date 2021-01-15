using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : SerializedMonoBehaviour
{
    public Dictionary<Tetromino.Letter, Tetromino> TetrominoPrefabs;
    public CityBlock blockPrefab;

    public float previewPlaneHeight;
    public float piecePlaneHeight;
    
    private City gameCity;
    private PieceBag bag;

    private Tetromino currentPiece;
    private Camera referenceCamera;
    private bool canPlacePiece;

    void Awake()
    {
        bag = new PieceBag();
        referenceCamera = Camera.main;
    }
    
    void Start()
    {
        StartGame();
    }

    void Update()
    {
        MoveCurrentPieceToMouse();
    }

    public void StartGame()
    {
        //place first piece
        currentPiece = SpawnPiece(Vector3.zero);
        canPlacePiece = true;
    }
    
    private void MoveCurrentPieceToMouse()
    {
        var worldPlane = new Plane(Vector3.up, Vector3.up * previewPlaneHeight);
        var ray = referenceCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        float distance;
        if (worldPlane.Raycast(ray, out distance))
        {
            Vector3 planePoint = ray.GetPoint(distance);
            currentPiece.transform.position = planePoint.Round();
        }
    }

    private Tetromino SpawnPiece(Vector3 position)
    {
        Tetromino.Letter nextLetter = bag.GetNextPieceLetter();
        Tetromino newTetromino = Instantiate(TetrominoPrefabs[nextLetter]);

        newTetromino.transform.position = position;
        
        return newTetromino;
    }

    public void PlaceCurrentPiece()
    {
        if (canPlacePiece)
        {
            StartCoroutine(PlaceCurrentPieceCoroutine());
        }
    }

    private IEnumerator PlaceCurrentPieceCoroutine()
    {
        CityBlock[] pieceBlocks = currentPiece.tetrominoBlocks.ToArray();
        Vector3[] piecePositions = currentPiece.tetrominoBlocks.Select(b => b.transform.position).ToArray();
        
        Destroy(currentPiece.gameObject);
        currentPiece = SpawnPiece(Vector3.zero);
        
        for(int i = 0; i < 4; i++)
        {
            piecePositions[i].y = piecePlaneHeight;
            CityBlock block = Instantiate(blockPrefab, piecePositions[i], Quaternion.identity);
            block.transform.localScale = new Vector3(0.0f, 1.0f, 0.0f);
            block.transform.DOScale(new Vector3(0.9f, 1.0f, 0.9f), 0.25f);

            yield return new WaitForSeconds(0.1f);
        }
    }

    public void RotateCurrentPiece()
    {
        currentPiece.transform.Rotate(0.0f, 90.0f, 0.0f);
    }
}
