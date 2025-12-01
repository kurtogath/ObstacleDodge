using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int hits = 0;

    public int Hits => hits;

    void Start()
    {
        ResetHits();
    }

    public event System.Action<int> OnScoreChanged;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit" )
        {
            AddHit();
        }
    }

    public void AddHit()
    {
        hits++;
        Debug.Log($"Score: {hits}");
        
        OnScoreChanged?.Invoke(hits);
    }

    public void ResetHits()
    {
        hits = 0;
        OnScoreChanged?.Invoke(hits);
        Debug.Log("Score reseteado");
    }
}
