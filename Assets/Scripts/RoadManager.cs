using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private GameObject roadPrefab;
    private float zOffset = 25.75f; // was 28.5
    private float height = 0.01f;
    [SerializeField] private GameObject[] oddsAndEnds;
    private void Start()
    {
        print("length of oddsandends is " + oddsAndEnds.Length);
    }

    public void TriggeredAt(Transform transform)
    {
        GameObject newRoad = Instantiate(roadPrefab);
        newRoad.transform.position = new Vector3(transform.position.x, height, zOffset);
        Transform placeHolder = newRoad.transform.Find("PlaceHolder");
        int i = Random.Range(0, oddsAndEnds.Length);
        print("getting flotsam at " + i);
        GameObject thingie = Instantiate(oddsAndEnds[i], placeHolder);
    }
}
